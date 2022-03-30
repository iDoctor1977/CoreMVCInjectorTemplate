using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Injector.Common.Models;
using Injector.Data.Builders;
using Injector.Data.Entities;
using Injector.Data.Interfaces.IRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Mocks
{
    public class RepositoryMock : IRepository
    {
        private IConfiguration Configuration { get; }
        private readonly IMapper _mapper;

        public RepositoryMock(IServiceProvider service, IConfiguration configuration)
        {
            Configuration = configuration;
            _mapper = service.GetRequiredService<IMapper>();

            var builder = new EntityBuilder();
            builder.AddEntity("Donald", "Duck").AddEntity("Foo", "Foo").Build();
        }

        private static readonly List<Entity> Entities = new List<Entity>
        {
            new Entity
            {
                Guid = Guid.NewGuid(),
                Name = "Foo",
                Surname = "Plans",
                IsDeleted = false
            },
            new Entity
            {
                Guid = Guid.NewGuid(),
                Name = "Donald",
                Surname = "Dack",
                IsDeleted = false
            },
            new Entity
            {
                Guid = Guid.NewGuid(),
                Name = "Pluto",
                Surname = "Pluto",
                IsDeleted = false
            },
            new Entity
            {
                Guid = Guid.NewGuid(),
                Name = "Micky",
                Surname = "Mouse",
                IsDeleted = false
            }
        };

        public int CreateEntity(CreateModel model)
        {
            return 1;
        }

        public ReadModel ReadEntityByGuid(Guid guid)
        {
            var entity = Entities.First();
            var model = _mapper.Map<ReadModel>(entity);

            return model;
        }
    }
}