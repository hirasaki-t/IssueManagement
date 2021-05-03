using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Model.DB.DataContext;
using Model.DB.DataService;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApp
{
    /// <summary>スタートアップ</summary>
    public class Startup
    {
        /// <summary>設定情報</summary>
        private readonly IConfiguration configuration;

        /// <summary>コンストラクタ</summary>
        /// <param name="configuration">設定情報</param>
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>DIコンテナ設定</summary>
        /// <param name="services">サービスコレクション</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                // cookieベースの認証
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.Events.OnRedirectToLogin = x =>
                {
                    // ログイン画面に遷移するのではなくエラーを返す
                    x.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    return Task.CompletedTask;
                };
                options.Events.OnRedirectToAccessDenied = x =>
                {
                    // エラー画面に遷移するのではなくエラーを返す
                    x.Response.StatusCode = StatusCodes.Status403Forbidden;
                    return Task.CompletedTask;
                };
                options.Events.OnRedirectToLogout = _ => Task.CompletedTask;
            });
            services.AddControllers(x =>
            {
                // すべてのアクセスに対して認証保護を適用する
                x.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
            });
            services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);
        });

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.Configure<Config>(configuration);
            services.AddDbContext<SQLServerDataContext>();
            services.AddTransient<IDataContext, SQLServerDataContext>();
            services.AddTransient<IDataService, DataService>();
        }

        /// <summary>アプリケーション設定</summary>
        /// <param name="app">アプリケーションビルダ</param>
        /// <param name="env">環境情報</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "課題管理システムAPI");
                });
            }
            else
            {
                app.UseHttpsRedirection();
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}