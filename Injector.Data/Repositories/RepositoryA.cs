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

        public int CreateEntity(AEntity aEntity)
        {
            try
            {
                if (aEntity != null)
                {
                    aEntity.Id = new Random().Next();
                    BaseRepository_DbContext.EntitiesA.Add(aEntity);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public int UpdateEntity(AEntity aEntity)
        {
            AEntity original = BaseRepository_DbContext.EntitiesA.Find(aEntity.Id);

            try
            {
                if (original != null)
                {
                    original.Name = aEntity.Name;
                    original.Surname = aEntity.Surname;

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public AEntity ReadEntityById(int id)
        {
            try
            {
                AEntity original = BaseRepository_DbContext.EntitiesA.Find(id);

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

        public AEntity ReadEntityByName(string name)
        {
            try
            {
                AEntity original = BaseRepository_DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

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

        public int DeleteEntity(AEntity aEntity)
        {
            try
            {
                AEntity original = BaseRepository_DbContext.EntitiesA.Find(aEntity.Id);

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
        public IEnumerable<AEntity> ReadEntities()
        {
            try
            {
                IEnumerable<AEntity> entitiesA = BaseRepository_DbContext.EntitiesA.ToList();

                if (entitiesA.Any())
                {
                    return entitiesA;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<AEntity>();
        }
    }
}
