using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Data.Depots;
using Injector.Data.Interfaces.IRepositories;
using Injector.Data.MapperProfiles;
using Injector.Data.Mocks;
using Injector.Data.Repositories;
using Injector.Web.Controllers;
using Injector.Web.Converters;
using Injector.Web.Interfaces.IMappers;
using Injector.Web.Interfaces.IPresenters;
using Injector.Web.MapperProfiles;
using Injector.Web.Models;
using Injector.Web.Presenters;
using Injectore.Core;
using Injectore.Core.Features;
using Injectore.Core.Interfaces;
using Injectore.Core.Steps.Create;
using Injectore.Core.Steps.Read;
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

        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Dependency Injection with Service Locator

            services.AddTransient<ICreateFeature, CreateFeature>();
            services.AddTransient<IReadFeature, ReadFeature>();

            services.AddTransient<IOperationsSupplier, OperationsSupplier>();

            services.AddTransient<CreateStep1A, CreateStep1A>();
            services.AddTransient<CreateStep1A_SubStep1, CreateStep1A_SubStep1>();
            services.AddTransient<CreateStep1A_SubStep2, CreateStep1A_SubStep2>();

            services.AddTransient<ReadStep1A, ReadStep1A>();
            services.AddTransient<ReadStep1A_SubStep1, ReadStep1A_SubStep1>();

            services.AddTransient<ICreateDepot, CreateDepot>();
            services.AddTransient<IReadDepot, ReadDepot>();

            if (Configuration["mocked"].Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                services.AddTransient<IRepository, RepositoryMock>();
            }
            else
            {
                services.AddTransient<IRepository, Repository>();
            }

            #endregion

            #region MAPPERS

            services.AddTransient(typeof(IPresenter<,>), typeof(DefaultPresenter<,>));
            services.AddTransient(typeof(IPresenter<ReadModel, ReadViewModel>), typeof(ReadPresenter));

            services.AddTransient(typeof(IModelMapper<,>), typeof(DefaultConverter<,>));
            services.AddTransient(typeof(IModelMapper<ReadViewModel, ReadModel>), typeof(ReadConverter));

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
