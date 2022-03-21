using NUnit.Framework;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using Injector.Common.Models;
using Injector.Web.Controllers;

namespace InjectorUnitTest.ControllerTests
{
    [TestFixture]
    public class CreateAControllerWebCommandTests : BaseTest
    {
        [Test(Description = "Verifica del funzionamnebto del comand CREATE")]
        public void CreateCommandWithValidInput()
        {
            // ARRANGE
            var vmCreateA = new CreateViewModel()
            {
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            MockRepositoryA.Setup(c => c.CreateEntity(It.IsAny<CreateRequestTransfertModel>())).Returns(1);
            var controllerATest = new HomeController(ServiceProvider);

            // ACT
            var result = controllerATest.Create(vmCreateA);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<CreateViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.CreateEntity(It.IsAny<CreateRequestTransfertModel>())), Times.Once());
        }
    }
}
