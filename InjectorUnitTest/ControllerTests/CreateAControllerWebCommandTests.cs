using NUnit.Framework;
using InjectorUnitTest.Common;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using Injector.Data.Entities;
using Injector.Web.Controllers;

namespace InjectorUnitTest.ControllerTests
{
    #region TEST AREA

    [TestFixture]
    public class CreateAControllerWebCommandTests : BaseTest
    {
        [Test(Description = "Verifica del funzionamnebto del comand CREATE")]
        public void CreateCommandWithValidInput()
        {
            // ARRANGE
            var vmCreateA = new VMCreateA()
            {
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            MockRepositoryA.Setup(c => c.CreateEntity(It.IsAny<EntityA>())).Returns(1);
            var controllerATest = new ModelAController(ServiceProvider);

            // ACT
            var result = controllerATest.Create(vmCreateA);

            // ASSERT
            result.Should().BeOfType<ViewResult>();
            result.Model.Should().BeOfType<VMCreateA>();
            result.Model.Should().NotBeNull();

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.CreateEntity(It.IsAny<EntityA>())), Times.Once());
        }
    }

    #endregion
}
