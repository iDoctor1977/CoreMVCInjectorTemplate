using Microsoft.EntityFrameworkCore;
using System;

namespace Injector.Data.ADOModels
{
    public class ProjectDbContext : DbContext
    {
        private readonly string _dbName;
        private readonly string _connectionStringName;

        public ProjectDbContext()
        {
            _dbName = "ProjectDB";
            _connectionStringName = CreateConnectionStringPath();
        }

        public ProjectDbContext(string dbName)
        {
            _dbName = dbName;
            _connectionStringName = CreateConnectionStringPath();
        }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public DbSet<EntityA> EntitiesA { get; set; }
        public DbSet<EntityB> EntitiesB { get; set; }
        public DbSet<EntityC> EntitiesC { get; set; }

        private string CreateConnectionStringPath() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            return $"Data Source={path}{System.IO.Path.DirectorySeparatorChar}" + _dbName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseInMemoryDatabase(_dbName);
            //optionsBuilder.UseSqlServer(_connectionStringName); 
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityA>().ToTable("EntityA");
            modelBuilder.Entity<EntityB>().ToTable("EntityB");
            modelBuilder.Entity<EntityC>().ToTable("EntityC");
        }
    }
}
