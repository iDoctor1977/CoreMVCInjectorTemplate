using System;
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
            var homeController = new Injector.Web.Controllers.HomeController(ServiceProvider);

            // ACT
            var result = homeController.Create(vmCreateA);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<CreateViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.CreateEntity(It.IsAny<CreateRequestTransfertModel>())), Times.Exactly(2));
        }

        [Test(Description = "Verifica del funzionamento del comando READ")]
        public void Should_ExecuteReadCommandWithValidInputAndReturnViewModel()
        {
            // ARRANGE
            var newGuid = Guid.NewGuid();

            var readViewModel = new ReadViewModel()
            {
                GuId = newGuid,
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            var readResponseTM = new ReadResponseTransfertModel
            {
                GuId = newGuid,
                Name = "Foo",
                Surname = "Foo Foo"
            };

            MockRepositoryA.Setup(c => c.ReadEntityByGuid(It.IsAny<Guid>())).Returns(readResponseTM);
            var homeController = new Injector.Web.Controllers.HomeController(ServiceProvider);

            // ACT
            var result = homeController.Read(readViewModel);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<ReadViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.ReadEntityByGuid(It.IsAny<Guid>())), Times.Once);
        }
    }
}
