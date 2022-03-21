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
    public class RepositoryA : BaseRepository, IRepositoryA
    {
        public RepositoryA(IServiceProvider service) : base(service) { }

        public RepositoryA(IServiceProvider service, string dbName) : base(service, dbName) { }

        public RepositoryA(IServiceProvider service, DbContextOptions<ProjectDbContext> options) : base(service, options) { }

        public int CreateEntity(CreateRequestTransfertModel transfertModel)
        {
            var entity = _mapper.Map<AEntity>(transfertModel);

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

        public int UpdateEntity(ReadRequestTransfertModel transfertModel)
        {
            var original = BaseRepository_DbContext.EntitiesA.Find(transfertModel.GuId);

            try
            {
                if (original != null)
                {
                    original.Name = transfertModel.Name;
                    original.Surname = transfertModel.Surname;

                    return Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return 0;
        }

        public ReadResponseTransfertModel ReadEntityByGuid(Guid guid)
        {
            try
            {
                var original = BaseRepository_DbContext.EntitiesA.Find(guid);

                if (original != null)
                {
                    var transfertModel = _mapper.Map<ReadResponseTransfertModel>(original);

                    return transfertModel;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public ReadResponseTransfertModel ReadEntityByName(string name)
        {
            try
            {
                var original = BaseRepository_DbContext.EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (original != null)
                {
                    var transfertModel = _mapper.Map<ReadResponseTransfertModel>(original);

                    return transfertModel;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public int DeleteEntity(CreateRequestTransfertModel transfertModel)
        {
            try
            {
                var original = BaseRepository_DbContext.EntitiesA.Find(transfertModel.GuId);

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
        public IEnumerable<CreateResponseTransfertModel> ReadEntities()
        {
            try
            {
                IEnumerable<AEntity> entities = BaseRepository_DbContext.EntitiesA.ToList();

                if (entities.Any())
                {
                    var transfertModels = _mapper.Map<IEnumerable<CreateResponseTransfertModel>>(entities);

                    return transfertModels;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<CreateResponseTransfertModel>();
        }
    }
}
