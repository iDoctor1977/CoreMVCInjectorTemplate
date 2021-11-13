using Injector.Frontend.Controllers;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using InjectorUnitTest.Common;
using Injector.Web.Models;

namespace InjectorUnitTest.Test
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
            VMCreateA vmCreateATest = new VMCreateA
            {
                Id = 1,
                Name = "Pippo",
                Surname = "iDoctor",
                TelNumber = "+39 331 578 7943"
            };

            // ACT

            // ASSERT
            
        }

        [Test]
        //[TestCase(ExpectedResult = "Pluto")]
        public void CreateWithValidInput()
        {
            // ARANGE

            // ACT

            // ASSERT
        }
    }

    #endregion
}
