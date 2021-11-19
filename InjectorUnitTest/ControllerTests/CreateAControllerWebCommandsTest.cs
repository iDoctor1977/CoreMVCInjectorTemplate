using NUnit.Framework;
using InjectorUnitTest.Common;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Injector.Frontend.Controllers;
using Injector.Data.ADOModels;
using Moq;
using FluentAssertions;

namespace InjectorUnitTest.ControllerTests
{
    #region TEST AREA

    [TestFixture]
    public class CreateAControllerWebCommandsTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            base.Setup();
        }

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
            var controllerATest = new ControllerA(ServiceProvider);

            // ACT
            RedirectToActionResult result = (RedirectToActionResult)controllerATest.Create(vmCreateA);

            // ASSERT
            result.ActionName.Should().Be("List");

            // Verify that DoesSomething was called only once
            MockRepositoryA.Verify((c => c.CreateEntity(It.IsAny<EntityA>())), Times.Once());
        }
    }

    #endregion
}
