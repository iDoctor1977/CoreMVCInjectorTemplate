using System;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Injector.Common.Models;
using Injector.Web.Models;
using Injector.Web.Testing.Fixtures;
using Xunit;

namespace Injector.Web.Testing.HomeController
{
    using Controllers;

    [Collection("BaseTest")]
    public class HomeControllerTests
    {
        private readonly BaseTestFixture _fixture;

        public HomeControllerTests(BaseTestFixture fixture)
        {
            _fixture = fixture;
            _fixture.RunSetup();
        }

        [Fact(DisplayName = "Verifica del funzionamento del comando CREATE")]
        public void Should_ExecuteCreateCommandWithValidInput()
        {
            // ARRANGE
            var createViewModel = new CreateViewModel()
            {
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            _fixture.MockRepository.Setup(c => c.CreateEntity(It.IsAny<CreateModel>())).Returns(1);
            var homeController = new HomeController(_fixture.ServiceProvider);

            // ACT
            var result = homeController.Create(createViewModel);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<CreateViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            _fixture.MockRepository.Verify((c => c.CreateEntity(It.IsAny<CreateModel>())), Times.Exactly(2));
        }

        [Fact(DisplayName = "Verifica del funzionamento del comando READ")]
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

            var readModel = new ReadModel
            {
                Guid = newGuid,
                Name = "Foo",
                Surname = "Foo Foo"
            };

            _fixture.MockRepository.Setup(c => c.ReadEntityByGuid(It.IsAny<Guid>())).Returns(readModel);
            var homeController = new HomeController(_fixture.ServiceProvider);

            // ACT
            var result = homeController.Read(readViewModel);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<ReadViewModel>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            _fixture.MockRepository.Verify((c => c.ReadEntityByGuid(It.IsAny<Guid>())), Times.Exactly(2));
        }
    }
}
