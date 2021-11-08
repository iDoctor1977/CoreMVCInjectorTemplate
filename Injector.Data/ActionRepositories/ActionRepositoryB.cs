using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.IStores;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryB : ABaseActionRepository, IActionRepositoryB
    {
        private static IActionRepositoryB ActionRepositoryAInstance { get; set; }

        #region CONSTRUCTOR

        private ActionRepositoryB() { }

        private ActionRepositoryB(IDataStore dataStore) : base(dataStore) { }

        #endregion

        #region SINGLETON

        public static IActionRepositoryB Instance()
        {
            if (ActionRepositoryAInstance == null)
            {
                ActionRepositoryAInstance = new ActionRepositoryB();
            }

            return ActionRepositoryAInstance;
        }

        public static IActionRepositoryB Instance(IDataStore dataStore)
        {
            if (ActionRepositoryAInstance == null)
            {
                ActionRepositoryAInstance = new ActionRepositoryB(dataStore);
            }

            return ActionRepositoryAInstance;
        }

        #endregion

        public bool CreateValue(DTOModelB dtoModelB)
        {
            // qui va fatto il mapping
            // qui vengono create le Entity
            // qui viene chiamato il repository

            throw new NotImplementedException();
        }

        public bool DeleteValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOModelB> ReadValues()
        {
            throw new NotImplementedException();
        }

        public DTOModelB ReadValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }

        public bool UpdateValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }
    }
}
