using Injector.Common.IEntities;
using Microsoft.EntityFrameworkCore;
using Injector.Common.IDbContexts;

namespace Injector.Data.ADOModels
{
    public class ProjectDbContext : DbContext, IProjectDbContext
    {
        private readonly string _connectionStringName;

        public ProjectDbContext(DbContextOptions options) : base(options) { }

        public ProjectDbContext(string connectionStringName)
        {
            _connectionStringName = connectionStringName;
        }

        //public ProjectDbContext(string dbName)
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    _connectionStringName = $"Data Source={path}{System.IO.Path.DirectorySeparatorChar}" + dbName;
        //}

        public DbSet<IEntityA> EntitiesA { get; set; }
        public DbSet<IEntityB> EntitiesB { get; set; }
        public DbSet<IEntityC> EntitiesC { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStringName);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityA>().ToTable("EntityA");
            modelBuilder.Entity<EntityB>().ToTable("EntityB");
            modelBuilder.Entity<EntityC>().ToTable("EntityC");
        }
    }
}
