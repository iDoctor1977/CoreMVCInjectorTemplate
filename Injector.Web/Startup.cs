using Injector.Common.ActionRepositories;
using Injector.Common.IABases;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Injector.Common.Repositories;
using Injector.Core;
using Injector.Core.Features;
using Injector.Core.Steps;
using Injector.Data;
using Injector.Web.Controllers;
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
            #region DI Injection.Web

            services.AddTransient<IABaseController, ABaseController>();
            services.AddTransient<IWebStore, WebStore>();
            #endregion

            #region DI Injector.Core

            services.AddTransient<ICoreSupplier, CoreSupplier>();
            services.AddTransient<ICoreStore, CoreStore>();
            services.AddTransient<IABaseFeature, ABaseFeature>();
            services.AddTransient(typeof(IABaseStep<>), typeof(ABaseStep<>));

            #endregion

            #region DI Injector Data

            services.AddTransient<IDataSupplier, DataSupplier>();
            services.AddTransient<IABaseActionRepository, ABaseActionRepository>();
            services.AddTransient<IDataStore, DataStore>();
            services.AddTransient<IABaseRepository, ABaseRepository>();

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
