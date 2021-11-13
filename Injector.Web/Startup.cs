using Injector.Common.ActionRepositories;
using Injector.Common.IActionRepositories;
using Injector.Common.IFeatures;
using Injector.Common.ISuppliers;
using Injector.Common.Repositories;
using Injector.Core;
using Injector.Core.Features;
using Injector.Data;
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

            services.AddTransient<IActionRepositoryA, ActionRepositoryA>();
            services.AddTransient<IActionRepositoryB, ActionRepositoryB>();

            services.AddTransient<RepositoryA, RepositoryA>();
            services.AddTransient<RepositoryB, RepositoryB>();

            //services.AddTransient<ProjectDbContext, ProjectDbContext>();

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
