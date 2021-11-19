using NUnit.Framework;
using InjectorUnitTest.Common;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Injector.Frontend.Controllers;
using Injector.Data.ADOModels;
using Microsoft.EntityFrameworkCore;
using System;

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

            var entityATest = new EntityA()
            {
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
