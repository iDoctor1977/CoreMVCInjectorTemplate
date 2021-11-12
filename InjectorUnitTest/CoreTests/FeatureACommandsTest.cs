using Injector.Common.DTOModels;
using NUnit.Framework;
using InjectorUnitTest.Common;

namespace InjectorUnitTest.Test
{
    #region TEST AREA

    [TestFixture]
    public class FeatureACommandsTest : BaseTest
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
            DTOModelA dtoModelA = new DTOModelA
            {
                Id = 1,
                Name = "Pippo",
                Surname = "Poppi"
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
