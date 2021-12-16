using System;
using Injector.Common.IActionRepositories;
using Injector.Common.IFeatures;
using Injector.Common.ISuppliers;
using Injector.Core;
using Injector.Core.Operator;
using Injector.Core.Operator.Steps.CreateA;
using Injector.Data.Depots;
using Injector.Data.IRepositories;
using Injector.Data.MapperProfiles;
using Injector.Data.Mocks;
using Injector.Data.Repositories;
using Injector.Web.MapperProfiles;
using Injectore.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Injector.Web
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
            #region Dependency Injection with Service Locator

            services.AddTransient<IOperatorSupplier, OperatorSupplier>();

            services.AddTransient<IFeatureA, FeatureA>();

            services.AddTransient<CreateStep1A, CreateStep1A>();
            services.AddTransient<CreateStep1A_SubStep1, CreateStep1A_SubStep1>();
            services.AddTransient<CreateStep1A_SubStep2, CreateStep1A_SubStep2>();

            services.AddTransient<IDepotA, DepotA>();

            if (Configuration["mocked"].Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                services.AddTransient<IRepositoryA, RepositoryAMock>();
            }
            else
            {
                services.AddTransient<IRepositoryA, RepositoryA>();
            }

            #endregion

            #region AUTOMAPPER

            services.AddAutoMapper(typeof(WebMappingProfile));
            services.AddAutoMapper(typeof(DataMappingProfile));

            #endregion

            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // tra UseAuthorization e UseEndpoints possono essere inserirti castom middlewares

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
