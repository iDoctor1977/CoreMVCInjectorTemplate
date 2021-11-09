using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Injector.Common.IEntities;
using Injector.Common.IRepositories;
using Injector.Data.ADOModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.Repositories
{
    public class RepositoryA : ABaseRepository, IRepositoryA
    {
        public RepositoryA(ServiceProvider service) : base(service) { }

        public int CreateEntity(IEntityA entityA)
        {
            try
            {
                if (entityA != null)
                {
                    entityA.Id = new Random().Next();

                    ABaseRepository_DbContext.EntitiesA.Add(entityA);

                    return entityA.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public bool UpdateEntity(IEntityA entityA)
        {
            EntityA original = (EntityA)ABaseRepository_DbContext.EntitiesA.Find(entityA.Id);

            try
            {
                if (original != null)
                {
                    original.Name = entityA.Name;
                    original.Surname = entityA.Surname;

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }

        public IEntityA ReadEntityById(int id)
        {
            try
            {
                IEntityA original = ABaseRepository_DbContext.EntitiesA.Find(id);

                if (original != null)
                {
                    return original;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public IEntityA ReadEntityByName(string name)
        {
            try
            {
                IEntityA original = ABaseRepository_DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (original != null)
                {
                    return original;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public IEnumerable<IEntityA> ReadEntities()
        {
            try
            {
                IEnumerable<IEntityA> entitiesA = ABaseRepository_DbContext.EntitiesA.ToList();

                if (entitiesA.Any())
                {
                    return entitiesA;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<IEntityA>();
        }

        public bool DeleteEntity(IEntityA entityA)
        {
            try
            {
                IEntityA original = ABaseRepository_DbContext.EntitiesA.Find(entityA.Id);

                if (original != null)
                {
                    ABaseRepository_DbContext.EntitiesA.Remove(original);

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }
    }
}
