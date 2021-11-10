using System;
using System.Collections.Generic;
using Injector.Core.Features;
using Injector.Common.DTOModels;
using Injector.Core;
using Injector.Common.IActionRepositories;
using Injector.Common.IFeatures;
using Injector.Common.IStores;
using Injector.Common.ISuppliers;
using Injector.Frontend.Controllers;
using NUnit.Framework;
using Injector.Common.IRepositories;
using Injector.Common.IEntities;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using Injector.Common.IBases;
using Injector.Common.IDbContexts;
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

            FeatureA featureATest = new FeatureA();

            // ACT
            bool result = featureATest.CreatePost(dtoModelA);

            // ASSERT
            Assert.IsTrue(result);
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
