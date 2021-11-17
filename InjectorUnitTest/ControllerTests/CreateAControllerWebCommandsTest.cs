using NUnit.Framework;
using InjectorUnitTest.Common;
using Injector.Web.Models;
using Injector.Frontend.Controllers;
using Microsoft.AspNetCore.Mvc;

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

        [Test(Description = "Verifica del funzionamnebto del comand CREATE della Feature")]
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

            ControllerA controllerATest = new ControllerA(services);

            // ACT
            ActionResult result = controllerATest.Create(vmCreateA);

            // ASSERT
            
        }
    }

    #endregion
}
