using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.IEntities;
using Injector.Common.IStores;
using Injector.Data.ADOModels;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryA : ABaseActionRepository, IActionRepositoryA
    {
        private static IActionRepositoryA ActionRepositoryAInstance { get; set; }

        #region CONSTRUCTOR

        private ActionRepositoryA() { }

        private ActionRepositoryA(IDataStore dataStore) : base(dataStore) { }

        #endregion

        #region SINGLETON

        public static IActionRepositoryA Instance()
        {
            if (ActionRepositoryAInstance == null)
            {
                ActionRepositoryAInstance = new ActionRepositoryA();
            }

            return ActionRepositoryAInstance;
        }

        public static IActionRepositoryA Instance(IDataStore dataStore)
        {
            if (ActionRepositoryAInstance == null)
            {
                ActionRepositoryAInstance = new ActionRepositoryA(dataStore);
            }

            return ActionRepositoryAInstance;
        }

        #endregion
         
        public bool CreateValue(DTOModelA dtoModelA)
        {
            // qui vengono create le Entity
            // qui va fatto il mapping
            // qui viene chiamato il repository

            EntityA entityA = new EntityA();
            entityA.Name = dtoModelA.Name;

            ABase_DataStore.DataRepositoryA.CreateEntity((IEntityA)entityA);
            ABase_DataStore.DataRepositoryA.ReadEntityById(entityA.Id);

            throw new NotImplementedException();
        }

        public bool DeleteValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOModelA> ReadValues()
        {
            throw new NotImplementedException();
        }

        public DTOModelA ReadValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public bool UpdateValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}
