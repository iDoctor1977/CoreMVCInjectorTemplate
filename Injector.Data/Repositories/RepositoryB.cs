using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Injector.Common.IRepositories;
using Injector.Common.IEntities;
using Microsoft.EntityFrameworkCore;
using Injector.Data.ADOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.Repositories
{
    public class RepositoryB : ABaseRepository, IRepositoryB
    {
        public RepositoryB(ServiceProvider service) : base(service) { }

        public int CreateEntity(IEntityB entityB)
        {
            try
            {
                if (entityB != null)
                {
                    entityB.Id = new Random().Next(); ;

                    RepositoryDbContext.EntitiesB.Add(entityB);

                    return entityB.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public bool UpdateEntity(IEntityB entityB)
        {
            EntityB original = (EntityB) RepositoryDbContext.EntitiesB.Find(entityB.Id);

            try
            {
                if (original != null)
                {
                    original.Username = entityB.Username;
                    original.Email = entityB.Email;

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }

        public IEntityB ReadEntityById(int id)
        {
            try
            {
                IEntityB original = RepositoryDbContext.EntitiesB.Find(id);

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

        public IEntityB ReadEntityByUsername(string username)
        {
            try
            {
                IEntityB original = RepositoryDbContext.EntitiesB.SingleOrDefault(eB => eB.Username == username);

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

        public IEnumerable<IEntityB> ReadEntities()
        {
            try
            {
                IEnumerable<IEntityB> entitiesB = RepositoryDbContext.EntitiesB.ToList();

                if (entitiesB.Any())
                {
                    return entitiesB;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<IEntityB>();
        }

        public bool DeleteEntity(IEntityB entityB)
        {
            try
            {
                IEntityB original = RepositoryDbContext.EntitiesB.Find(entityB.Id);

                if (original != null)
                {
                    RepositoryDbContext.EntitiesB.Remove(original);

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
