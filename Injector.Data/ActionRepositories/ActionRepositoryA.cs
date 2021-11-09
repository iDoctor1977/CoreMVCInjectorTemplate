using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.IActionRepositories;
using Injector.Common.IEntities;
using Injector.Data.ADOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryA : BaseActionRepository, IActionRepositoryA
    {
        public ActionRepositoryA(ServiceProvider service) : base(service) { }

        public bool CreateValue(DTOModelA dtoModelA)
        {
            // qui vengono create le Entity
            // qui va fatto il mapping
            // qui viene chiamato il repository

            EntityA entityA = new EntityA();
            entityA.Name = dtoModelA.Name;

            BaseActionRepository_DataStore.GetRepositoryA.CreateEntity((IEntityA)entityA);
            BaseActionRepository_DataStore.GetRepositoryA.ReadEntityById(entityA.Id);

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
