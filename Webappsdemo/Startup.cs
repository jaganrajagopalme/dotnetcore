using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Webappsdemo.Models;
using System.Configuration;

namespace Webappsdemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfiguration _config;
        public Startup(IConfiguration Iconfig)
        {
            _config = Iconfig;
        }
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddDbContext<Appcontext>(obj=>obj.Options.)
            services.AddDbContext<Appcontext>(options =>options.UseSqlServer(_config.GetConnectionString("RazorPagesMovieContext")));
            services.AddControllersWithViews().AddXmlSerializerFormatters();
            services.AddSingleton<IProductRepo, ProductRepos>();
            services.AddSingleton<IDepartmentRepo, MockDepartmentRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env ,ILogger<Startup> logger)
        {
            logger.LogInformation("Log env" + env.EnvironmentName);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //if (env.IsEnvironment("Development"))
            //{
            //    logger.LogInformation("envoirnoment" + env.EnvironmentName);
            //}

             app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async (context ) =>
            //    {
            //        await context.Response.WriteAsync(_config["Mykey"]);
            //        //await next();
            //    });
            //});

            //DefaultFilesOptions defaultfile = new DefaultFilesOptions();
            //defaultfile.DefaultFileNames.Clear();
            //defaultfile.DefaultFileNames.Add("mysample.html");

            //FileServerOptions fileoptions = new FileServerOptions();
            //fileoptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileoptions.DefaultFilesOptions.DefaultFileNames.Add("mysample.html");
            //app.UseFileServer(fileoptions);
            // app.UseDefaultFiles(defaultfile);
            // app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //                Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"static")),
            //    RequestPath = new PathString("/static")
            //});
            //app.UseMvcWithDefaultRoute();
            //app.UseEndpoints(endpoints =>
            //{
            //    //endpoints.MapHub<ChatHub>("/chat");
            //    endpoints.MapControllerRoute("default", "{controller=Index}/{action=Index}/{id?}");
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run(async context =>
           {
               await context.Response.WriteAsync("Hello from 2nd delegate.");
                //logger.LogInformation("MW1 Request");
                //await next();
                //logger.LogInformation("MW1 Response");
            });



            // app.Use(async (context,next) => { await context.Response.WriteAsync("alsdfjsdf");await next()});

            //app.Use(async (context,next) => {
            //    //await context.Response.WriteAsync("Hello from 3nd delegate");
            //    logger.LogInformation("MW2 Request");
            //    await next();
            //    logger.LogInformation("MW2 Response");
            //});
            //app.Run(async context =>
            //{
            //    logger.LogInformation("MW3 Request");
            //    await context.Response.WriteAsync("Hellow from 3nd delegate"); 
            //    logger.LogInformation("MW3 Response");
            //});

        }
    }
}
