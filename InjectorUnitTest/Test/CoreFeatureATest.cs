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

            DTOModelA result = new DTOModelA();

            IEntityA mockEntityA = Substitute.For<EntityAMock>();

            IRepositoryA mockRepositoryA = Substitute.For<RepositoryAMock>();
            mockRepositoryA.CreateEntity(mockEntityA);

            IDataStore mockDataStore = Substitute.For<DataStoreMock>();
            IDataSupplier mockDataSupplier = Substitute.For<DataSupplierMock>();
            ICoreStore mockCoreStore = Substitute.For<CoreStoreMock>();

            // ACT
            ICoreSupplier testCoreSupplier = CoreSupplier.Instance(mockCoreStore);
            testCoreSupplier.GetFeatureA.CreatePost(modelA);
            result = testCoreSupplier.GetFeatureA.DetailsGet(modelA);

            // ASSERT
            Assert.IsInstanceOf<DTOModelA>(result);
            Assert.AreEqual(modelA.Id, result.Id);
        }

        [Test]
        //[TestCase(ExpectedResult = "Pluto")]
        public void CreateWithValidInput()
        {
            // ARANGE
            DTOModelA  modelA= new DTOModelA
            {
                Id = 1,
                Name = "Pippo",
                Surname = "Foia",
            };

            //IModelA modelASubstitute = Substitute.For<IModelA>();
            //modelASubstitute.Id = 3;
            //modelASubstitute.Name = "Pluto";
            //modelASubstitute.Surname = "Paperino";

            IFeatureA featureASubstitute = Substitute.For<FeatureA>();
            //featureASubstitute.DetailsGet(Arg.Any<VMDetailsA>()).Returns(vmDetailsA);

            //IBusinessStore businessStoreSubstitute = Substitute.For<IBusinessStore>();
            //businessStoreSubstitute.GetOperatorA().Returns(operatorASubstitute);

            ICoreSupplier coreSupplierSubstitute = Substitute.For<ICoreSupplier>();
            coreSupplierSubstitute.GetFeatureA.Returns(featureASubstitute);

            IWebStore webStoreSubstitute = Substitute.For<IWebStore>();
            webStoreSubstitute.WebStore_CoreSupplierInstance.Returns(coreSupplierSubstitute);

            // ACT
            var homeController = new ControllerA(webStoreSubstitute);
            ActionResult result = homeController.List();

            // ASSERT
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<DTOModelA>((result as ViewResult).Model);
            //Assert.AreEqual(vmDetailsA, ((VMCreateA)(result as ViewResult).Model));

            //OperatorA operatorA = new OperatorA(new DataSupplierMock());

            //AController aController = new AController(new BusinessSupplierMock());
            //IModelA value = aController.operatorA.ReadModel(2);

            //viewModelA = operatorA.ReadModel(2);

            //Assert.IsInstanceOf<IModelA>(viewModelA);
            //Assert.AreEqual(3, viewModelA.Id);
            //Assert.AreEqual("Pluto", viewModelA.Name);
            //Assert.AreEqual("Paperino", viewModelA.Surname);

            //return viewModelA.Name;
        }
    }

    internal class FeatureAMock : IFeatureA
    {
        public bool CreatePost(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public DTOModelA DeleteGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public DTOModelA DetailsGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public DTOModelA EditGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public bool EditPost(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public DTOModelA ListGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region MOCK FOR TEST 1

    public class EntityAMock : IEntityA
    {
        int IEntityA.Id { get => 1; set => throw new NotImplementedException(); }
        string IEntityA.Name { get => "result name of test 1 is this"; set => throw new NotImplementedException(); }
        string IEntityA.Surname { get => "result surname of test 1 is this"; set => throw new NotImplementedException(); }
        bool ISoftDelete.IsDeleted { get => false; set => throw new NotImplementedException(); }
        string ISoftDelete.DeleteBy { get => string.Empty; set => throw new NotImplementedException(); }
        DateTime? ISoftDelete.DeleteDate { get => DateTime.Now; set => throw new NotImplementedException(); }
    }

    public class RepositoryAMock : IRepositoryA
    {
        public int CreateEntity(IEntityA entityA)
        {
            return entityA.Id;
        }

        public bool DeleteEntity(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntityA> ReadEntities()
        {
            throw new NotImplementedException();
        }

        public IEntityA ReadEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(IEntityA entityA)
        {
            throw new NotImplementedException();
        }
    }

    public class ActionRepositoryAMock : IActionRepositoryA
    {
        public bool CreateValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public bool DeleteValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public DTOModelA ReadValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOModelA> ReadValues()
        {
            throw new NotImplementedException();
        }

        public bool UpdateValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }

    public class DataStoreMock : IDataStore
    {
        public IRepositoryA GetRepositoryA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryB GetRepositoryB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class DataSupplierMock : IDataSupplier
    {
        public IDataStore DataSupplier_DataStoreInstance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IActionRepositoryA GetActionRepositoryA => throw new NotImplementedException();

        public IActionRepositoryB GetActionRepositoryB => throw new NotImplementedException();
    }

    public class CoreStoreMock : ICoreStore
    {
        public IDataSupplier CoreStore_DataSupplierInstance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class CoreSupplierMock : ICoreSupplier
    {
        public ICoreStore CoreSupplie_CoreStoreInstance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IFeatureA GetFeatureA => throw new NotImplementedException();

        public IFeatureB GetFeatureB => throw new NotImplementedException();
    }

    #endregion
}
