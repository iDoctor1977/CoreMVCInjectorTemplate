using System;
using AutoMapper;
using Injector.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly IMapper _mapper;

        protected BaseRepository (IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext();
        }

        protected BaseRepository(IServiceProvider service, string dbName)
        {
            _mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext(dbName);
        }

        protected BaseRepository(IServiceProvider service, DbContextOptions<ProjectDbContext> options)
        {
            _mapper = service.GetRequiredService<IMapper>();
            DbContext = new ProjectDbContext(options);
        }

        protected ProjectDbContext DbContext { get; }

        protected int Commit()
        {
            return DbContext.SaveChanges();
        }
    }
}
