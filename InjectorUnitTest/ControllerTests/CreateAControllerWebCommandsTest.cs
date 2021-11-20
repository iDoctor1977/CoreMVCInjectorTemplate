using NUnit.Framework;
using InjectorUnitTest.Common;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Injector.Frontend.Controllers;
using Injector.Data.ADOModels;

namespace InjectorUnitTest.ControllerTests
{
    #region TEST AREA

    [TestFixture]
    public class CreateAControllerWebCommandsTest : BaseTest
    {
        [Test(Description = "Verifica del funzionamnebto del comand CREATE")]
        public void CreateCommandWithValidInput()
        {
            // ARRANGE
            var vmCreateA = new VMCreateA()
            {
                Id = 1,
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            var entityATest = new EntityA()
            {
                Id = 1,
                Name = "Pippo",
                Surname = "iDoctor"
            };

            MokRepositoryA.Setup(m => m.CreateEntity(entityATest)).Returns(1);
            var controllerATest = new ControllerA(ServiceProvider);

            // ACT
            ActionResult result = controllerATest.Create(vmCreateA);

            // ASSERT
            
        }
    }

    #endregion
}
