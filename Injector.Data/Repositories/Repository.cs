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
            var entity = _mapper.Map<Entity>(model);

            try
            {
                if (entity != null)
                {
                    entity.Id = new Random().Next();
                    BaseRepository_DbContext.EntitiesA.Add(entity);

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
            var original = BaseRepository_DbContext.EntitiesA.Find(model.Guid);

            try
            {
                if (original != null)
                {
                    original.Name = model.Name;
                    original.Surname = model.Surname;

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
                var original = BaseRepository_DbContext.EntitiesA.Find(guid);

                if (original != null)
                {
                    var transfertModel = _mapper.Map<ReadModel>(original);

                    return transfertModel;
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
                var original = BaseRepository_DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (original != null)
                {
                    var transfertModel = _mapper.Map<ReadModel>(original);

                    return transfertModel;
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
                var original = BaseRepository_DbContext.EntitiesA.Find(model.Guid);

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

        public IEnumerable<ReadModel> ReadEntities()
        {
            try
            {
                IEnumerable<Entity> entities = BaseRepository_DbContext.EntitiesA.ToList();

                if (entities.Any())
                {
                    var models = _mapper.Map<IEnumerable<ReadModel>>(entities);

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
