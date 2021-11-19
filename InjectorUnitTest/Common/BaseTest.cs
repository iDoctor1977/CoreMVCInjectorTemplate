using Injector.Data.ADOModels;
using Injector.Data.IRepositories;
using Injector.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;

namespace InjectorUnitTest.Common
{
    public class BaseTest
    {
        protected IServiceProvider ServiceProvider { get; set; }
        protected Mock<IRepositoryA> MockRepositoryA { get; set; }

        [OneTimeSetUp]
        public void TestRunSetup()
        {
            MockRepositoryA = new Mock<IRepositoryA>();

            var host = Host.CreateDefaultBuilder().ConfigureWebHostDefaults(hostBuilder =>
            {
                hostBuilder.UseStartup<Startup>();
            }).ConfigureServices(services =>
            {
                var descriptor = services.FirstOrDefault(descriptor => descriptor.ServiceType == typeof(IRepositoryA));
                services.Remove(descriptor);
                services.Replace(new ServiceDescriptor(typeof(IRepositoryA), MockRepositoryA.Object));

                // in memory Database
                //var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ProjectDbContext>));
                //services.Remove(descriptor);
                //services.AddDbContext<ProjectDbContext>(options =>
                //{
                //    options.UseInMemoryDatabase("InMemoryDbForTesting");
                //});
            }).Build();

            IServiceScope serviceScope = host.Services.CreateScope();
            ServiceProvider = serviceScope.ServiceProvider;
        }
    }
}
