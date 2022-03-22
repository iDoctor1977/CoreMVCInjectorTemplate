using FluentAssertions;
using Injector.Common.Models;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace InjectorUnitTest.HomeController
{
    [TestFixture]
    public class CreateAControllerWebCommandTests : BaseTest
    {
        [Test(Description = "Verifica del funzionamento del comando CREATE")]
        public void Should_ExecuteCreateCommandWithValidInput()
        {
            // ARRANGE
            var vmCreateA = new CreateViewModel()
            {
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            MockRepositoryA.Setup(c => c.CreateEntity(It.IsAny<CreateRequestTransfertModel>())).Returns(1);
            var controllerATest = new Injector.Web.Controllers.HomeController(ServiceProvider);

            // ACT
            var result = controllerATest.Create(vmCreateA);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<CreateViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.CreateEntity(It.IsAny<CreateRequestTransfertModel>())), Times.Exactly(2));
        }
    }
}
