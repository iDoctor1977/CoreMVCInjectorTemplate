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

        private readonly ProjectDbContext _projectDbContext;

        protected BaseRepository (IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext();
        }

        protected BaseRepository(IServiceProvider service, string dbName)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext(dbName);
        }

        protected BaseRepository(IServiceProvider service, DbContextOptions<ProjectDbContext> options)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext(options);
        }

        protected ProjectDbContext BaseRepository_DbContext => _projectDbContext;

        protected int Commit()
        {
            ProjectDbContext dbContext = BaseRepository_DbContext;
            return dbContext.SaveChanges();
        }
    }
}
