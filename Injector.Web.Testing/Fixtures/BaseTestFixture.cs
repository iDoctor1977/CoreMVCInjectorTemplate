using System;
using System.Linq;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Moq;

namespace Injector.Web.Testing.Fixtures
{
    public class BaseTestFixture
    {
        public IServiceProvider ServiceProvider { get; set; }
        public Mock<IRepository> MockRepository { get; set; }

        public void RunSetup()
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
