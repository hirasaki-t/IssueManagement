using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Web;
using System;

namespace WebApp
{
    /// <summary>�G���g���|�C���g���܂ރN���X</summary>
    public class Program
    {
        /// <summary>�G���g���|�C���g</summary>
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Info("�A�v���P�[�V�������N��");
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

        /// <summary>Host��������</summary>
        /// <returns>Host�r���_�[</returns>
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