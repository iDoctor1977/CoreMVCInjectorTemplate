using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryB : IActionRepositoryB
    {
        public ActionRepositoryB(IServiceProvider service){ }

        public OperationResult<bool> CreateValue(DTOModelB dtoModelB)
        {
            // qui va fatto il mapping
            // qui vengono create le Entity
            // qui viene chiamato il repository

            throw new NotImplementedException();
        }

        public OperationResult<bool> DeleteValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }

        public OperationResult<IEnumerable<DTOModelB>> ReadValues()
        {
            throw new NotImplementedException();
        }

        public OperationResult<DTOModelB> ReadValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }

        public OperationResult<bool> UpdateValue(DTOModelB dtoModelB)
        {
            throw new NotImplementedException();
        }
    }
}
