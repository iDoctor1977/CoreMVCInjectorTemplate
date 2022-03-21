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

        public BaseRepository (IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext();
        }

        public BaseRepository(IServiceProvider service, string dbName)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext(dbName);
        }

        public BaseRepository(IServiceProvider service, DbContextOptions<ProjectDbContext> options)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _projectDbContext = new ProjectDbContext(options);
        }

        public ProjectDbContext BaseRepository_DbContext => _projectDbContext;

        public int Commit()
        {
            ProjectDbContext dbContext = BaseRepository_DbContext;
            return dbContext.SaveChanges();
        }
    }
}
