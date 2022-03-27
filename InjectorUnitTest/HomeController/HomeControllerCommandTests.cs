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
    public class HomeControllerCommandTests : BaseTest
    {
        [Test(Description = "Verifica del funzionamento del comando CREATE")]
        public void Should_ExecuteCreateCommandWithValidInput()
        {
            // ARRANGE
            var createViewModel = new CreateViewModel()
            {
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            MockRepository.Setup(c => c.CreateEntity(It.IsAny<CreateModel>())).Returns(1);
            var homeController = new Injector.Web.Controllers.HomeController(ServiceProvider);

            // ACT
            var result = homeController.Create(createViewModel);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<CreateViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepository.Verify((c => c.CreateEntity(It.IsAny<CreateModel>())), Times.Exactly(2));
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

            var readResponseTm = new ReadModel
            {
                Guid = newGuid,
                Name = "Foo",
                Surname = "Foo Foo"
            };

            MockRepository.Setup(c => c.ReadEntityByGuid(It.IsAny<Guid>())).Returns(readResponseTm);
            var homeController = new Injector.Web.Controllers.HomeController(ServiceProvider);

            // ACT
            var result = homeController.Read(readViewModel);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<ReadViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepository.Verify((c => c.ReadEntityByGuid(It.IsAny<Guid>())), Times.Exactly(2));
        }
    }
}
