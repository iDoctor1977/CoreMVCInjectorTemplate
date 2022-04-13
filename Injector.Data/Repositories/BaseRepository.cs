using System;
using AutoMapper;
using Injector.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly IMapper Mapper;

        protected BaseRepository (IServiceProvider service) {
            Mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext();
        }

        protected BaseRepository(IServiceProvider service, string dbName)
        {
            Mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext(dbName);
        }

        protected BaseRepository(IServiceProvider service, DbContextOptions<ProjectDbContext> options)
        {
            Mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext(options);
        }

        protected ProjectDbContext DbContext { get; }

        protected int Commit()
        {
            return DbContext.SaveChanges();
        }
    }
}
