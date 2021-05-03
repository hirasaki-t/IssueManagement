using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Web;
using System;

namespace WebApp
{
    /// <summary>エントリポイントを含むクラス</summary>
    public class Program
    {
        /// <summary>エントリポイント</summary>
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Info("アプリケーションを起動");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        /// <summary>Host生成処理</summary>
        /// <returns>Hostビルダー</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder()
#if DEBUG
                .UseEnvironment("Development")
#elif TEST
                .UseEnvironment("Staging")
#elif RELEASE
                .UseEnvironment("Production")
#endif
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseNLog();
    }
}