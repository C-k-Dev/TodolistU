using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TodolistU
{
    public class Startup
    {
        // Övrig kod...

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Övrig konfiguration...

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "add",
                    pattern: "Home/Add",
                    defaults: new { controller = "Home", action = "Add" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
