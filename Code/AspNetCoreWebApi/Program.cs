using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace AspNetCoreWebApi
{
    public static class Program
    {
        private static readonly ILogger Logger =
            new LoggerConfiguration().WriteTo.Console()
                                     .WriteTo.RollingFile(Path.Combine("Logs", "{Date} Web API.log"))
                                     .CreateLogger();

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog(Logger)
                .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>();
                 });
    }
}