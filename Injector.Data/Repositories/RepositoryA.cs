using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Injector.Data.Entities;
using Injector.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Injector.Data.Repositories
{
    public class RepositoryA : BaseRepository, IRepositoryA
    {
        public RepositoryA() : base() { }

        public RepositoryA(string dbName) : base(dbName) { }

        public RepositoryA(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public int CreateEntity(EntityA entityA)
        {
            try
            {
                if (entityA != null)
                {
                    entityA.Id = new Random().Next();
                    BaseRepository_DbContext.EntitiesA.Add(entityA);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public int UpdateEntity(EntityA entityA)
        {
            EntityA original = BaseRepository_DbContext.EntitiesA.Find(entityA.Id);

            try
            {
                if (original != null)
                {
                    original.Name = entityA.Name;
                    original.Surname = entityA.Surname;

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public EntityA ReadEntityById(int id)
        {
            try
            {
                EntityA original = BaseRepository_DbContext.EntitiesA.Find(id);

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

        public EntityA ReadEntityByName(string name)
        {
            try
            {
                EntityA original = BaseRepository_DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

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

        public int DeleteEntity(EntityA entityA)
        {
            try
            {
                EntityA original = BaseRepository_DbContext.EntitiesA.Find(entityA.Id);

                if (original != null)
                {
                    BaseRepository_DbContext.EntitiesA.Remove(original);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }
        public IEnumerable<EntityA> ReadEntities()
        {
            try
            {
                IEnumerable<EntityA> entitiesA = BaseRepository_DbContext.EntitiesA.ToList();

                if (entitiesA.Any())
                {
                    return entitiesA;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<EntityA>();
        }
    }
}
