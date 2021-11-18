using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Injector.Data.ADOModels;
using Injector.Data.IRepositories;

namespace Injector.Common.Repositories
{
    public class RepositoryB : BaseRepository, IRepositoryB
    {
        public RepositoryB(IServiceProvider service) : base(service) { }

        public int CreateEntity(EntityB entityB)
        {
            try
            {
                if (entityB != null)
                {
                    entityB.Id = new Random().Next();
                    BaseRepository_DbContext.EntitiesB.Add(entityB);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public int UpdateEntity(EntityB entityB)
        {
            EntityB original = BaseRepository_DbContext.EntitiesB.Find(entityB.Id);

            try
            {
                if (original != null)
                {
                    original.Username = entityB.Username;
                    original.Email = entityB.Email;

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public EntityB ReadEntityById(int id)
        {
            try
            {
                EntityB original = BaseRepository_DbContext.EntitiesB.Find(id);

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

        public EntityB ReadEntityByUsername(string username)
        {
            try
            {
                EntityB original = BaseRepository_DbContext.EntitiesB.SingleOrDefault(eB => eB.Username == username);

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

        public int DeleteEntity(EntityB entityB)
        {
            try
            {
                EntityB original = BaseRepository_DbContext.EntitiesB.Find(entityB.Id);

                if (original != null)
                {
                    BaseRepository_DbContext.EntitiesB.Remove(original);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public IEnumerable<EntityB> ReadEntities()
        {
            try
            {
                IEnumerable<EntityB> entitiesB = BaseRepository_DbContext.EntitiesB.ToList();

                if (entitiesB.Any())
                {
                    return entitiesB;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<EntityB>();
        }
    }
}
