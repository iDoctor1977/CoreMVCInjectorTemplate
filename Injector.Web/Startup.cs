using AutoMapper;
using Injector.Common.ActionRepositories;
using Injector.Common.IActionRepositories;
using Injector.Common.IFeatures;
using Injector.Common.ISteps.A;
using Injector.Common.ISteps.B;
using Injector.Common.ISuppliers;
using Injector.Common.Repositories;
using Injector.Core;
using Injector.Core.CaseDTOModels;
using Injector.Core.Features;
using Injector.Core.Steps.A;
using Injector.Core.Steps.B;
using Injector.Data;
using Injector.Data.ADOModels;
using Injector.Data.IRepositories;
using Injector.Web.MapperProfiles;
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

            services.AddTransient<ICoreSupplier, CoreSupplier>();
            services.AddTransient<IDataSupplier, DataSupplier>();

            services.AddTransient<IFeatureA, FeatureA>();
            services.AddTransient<IFeatureB, FeatureB>();

            // pipeline dependency injection
            services.AddTransient<ICreateStep1A<CaseDTOModelA>, CreateStep1A>();
            services.AddTransient<ICreateStep2A<CaseDTOModelA>, CreateStep2A>();
            services.AddTransient<ICreateStep3A<CaseDTOModelA>, CreateStep3A>();
            services.AddTransient<IDeleteStep1A<CaseDTOModelA>, DeleteStep1A>();
            services.AddTransient<IDeleteStep2A<CaseDTOModelA>, DeleteStep2A>();

            services.AddTransient<ICreateStep1B<CaseDTOModelB>, CreateStep1B>();
            services.AddTransient<ICreateStep2B<CaseDTOModelB>, CreateStep2B>();
            services.AddTransient<ICreateStep3B<CaseDTOModelB>, CreateStep3B>();
            // pipeline dependency injection

            services.AddTransient<IActionRepositoryA, ActionRepositoryA>();
            services.AddTransient<IActionRepositoryB, ActionRepositoryB>();

            services.AddTransient<IRepositoryA, RepositoryA>();
            services.AddTransient<IRepositoryB, RepositoryB>();

            #endregion

            #region AUTOMAPPER

            services.AddAutoMapper(typeof(MappingProfile));

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
