using System;
using AspNetCoreWebApi.SignUp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreWebApi
{
    public sealed class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                    .AddControllersAsServices();

            var inMemorySession = InMemorySignUpSession.CreateDefault();
            services.AddSingleton<Func<ISignUpSession>>(() => inMemorySession);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting()
               .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}