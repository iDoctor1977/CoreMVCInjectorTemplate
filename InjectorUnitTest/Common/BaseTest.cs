using Injector.Web;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;

namespace InjectorUnitTest.Common
{
    public class BaseTest
    {
        internal IServiceProvider services;

        [OneTimeSetUp]
        public void TestRunSetup()
        {
            IWebHost webHost = WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build();
            IServiceScope serviceScope = webHost.Services.CreateScope();
            services = serviceScope.ServiceProvider;
        }

        [SetUp]
        public virtual void Setup()
        {
        }
    }
}
