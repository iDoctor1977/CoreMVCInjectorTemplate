using System;
using System.Linq;
using Injector.Data.Interfaces.IRepositories;
using Injector.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Moq;
using NUnit.Framework;

namespace InjectorUnitTest
{
    public class BaseTest
    {
        protected IServiceProvider ServiceProvider { get; set; }
        protected Mock<IRepository> MockRepository { get; set; }

        [OneTimeSetUp]
        public void TestRunSetup()
        {
            MockRepository = new Mock<IRepository>();

            var host = Host.CreateDefaultBuilder().ConfigureWebHostDefaults(hostBuilder =>
            {
                hostBuilder.UseStartup<Startup>();
            }).ConfigureServices(services =>
            {
                var descriptor = services.FirstOrDefault(descriptor => descriptor.ServiceType == typeof(IRepository));
                services.Remove(descriptor);
                services.Replace(new ServiceDescriptor(typeof(IRepository), MockRepository.Object));

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
