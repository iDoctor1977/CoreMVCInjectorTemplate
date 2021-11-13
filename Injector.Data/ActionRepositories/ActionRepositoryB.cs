using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryB : BaseActionRepository, IActionRepositoryB
    {
        public ActionRepositoryB(IServiceProvider service) : base(service) { }

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
