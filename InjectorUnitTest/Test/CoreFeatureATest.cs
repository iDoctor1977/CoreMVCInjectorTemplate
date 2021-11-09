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

namespace InjectorUnitTest.Test
{
    #region TEST AREA

    [TestFixture]
    public class CoreFeatureATest
    {
        [Test]
        public void CreateEntityWithValidInput()
        {
            // ARRANGE
            DTOModelA modelA = new DTOModelA
            {
                Id = 0,
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
