using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Injector.Common.Models;
using Injector.Data.Builders;
using Injector.Data.Entities;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Mocks
{
    public class RepositoryMock : IRepository
    {
        private readonly IMapper _mapper;
        private readonly IEnumerable<Entity> _readModels;

        public RepositoryMock(IServiceProvider service)
        {
            _mapper = service.GetRequiredService<IMapper>();

            var builder = new EntityBuilder();
            builder.AddEntity("Donald", "Duck").AddEntity("Foo", "Foo").Build();
        }

        public int CreateEntity(CreateModel model)
        {
            return 1;
        }

        public ReadModel ReadEntityByGuid(Guid guid)
        {
            var entity = _readModels.First();
            var model = _mapper.Map<ReadModel>(entity);

            return model;
        }
    }
}