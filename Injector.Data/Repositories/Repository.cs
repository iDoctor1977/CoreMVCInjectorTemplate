using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Injector.Common.Models;
using Injector.Data.Entities;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Injector.Data.Repositories
{
    public class Repository : BaseRepository, IRepository
    {
        public Repository(IServiceProvider service) : base(service) { }

        public Repository(IServiceProvider service, string dbName) : base(service, dbName) { }

        public Repository(IServiceProvider service, DbContextOptions<ProjectDbContext> options) : base(service, options) { }

        public int CreateEntity(CreateModel model)
        {
            var entity = Mapper.Map<Entity>(model);

            try
            {
                if (entity != null)
                {
                    entity.Id = new Random().Next();
                    DbContext.EntitiesA.Add(entity);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public int UpdateEntity(ReadModel model)
        {
            var entity = DbContext.EntitiesA.Find(model.Guid);

            try
            {
                if (entity != null)
                {
                    entity.Name = model.Name;
                    entity.Surname = model.Surname;

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public ReadModel ReadEntityByGuid(Guid guid)
        {
            try
            {
                var entity = DbContext.EntitiesA.Find(guid);

                if (entity != null)
                {
                    var model = Mapper.Map<ReadModel>(entity);

                    return model;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public ReadModel ReadEntityByName(string name)
        {
            try
            {
                var entity = DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (entity != null)
                {
                    var model = Mapper.Map<ReadModel>(entity);

                    return model;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public int DeleteEntity(ReadModel model)
        {
            try
            {
                var entity = DbContext.EntitiesA.Find(model.Guid);

                if (entity != null)
                {
                    DbContext.EntitiesA.Remove(entity);

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public IEnumerable<ReadModel> ReadEntities()
        {
            try
            {
                IEnumerable<Entity> entities = DbContext.EntitiesA.ToList();

                if (entities.Any())
                {
                    var models = Mapper.Map<IEnumerable<ReadModel>>(entities);

                    return models;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<ReadModel>();
        }
    }
}
