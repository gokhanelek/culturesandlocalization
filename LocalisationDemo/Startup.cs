using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using LocalisationDemo.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using LocalisationDemo.Resources;
using System.Reflection;

namespace LocalisationDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddRazorPages();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                 {
                    new CultureInfo("en"),
                    new CultureInfo("tr"),
                    new CultureInfo("en-US")
                };
                options.DefaultRequestCulture = new RequestCulture("tr");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix, opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                       {
                           var assemblyName = new AssemblyName(typeof(CommonResources).GetTypeInfo().Assembly.FullName);
                           return factory.Create(nameof(CommonResources), assemblyName.Name);
                       };
                });
            services.AddSingleton<CommonLocalizationService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            var localizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value;
            app.UseRequestLocalization(localizationOptions);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
