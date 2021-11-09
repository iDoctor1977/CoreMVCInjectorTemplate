using Injector.Common.IDbContexts;

namespace Injector.Common.IBases
{
    public interface IBaseRepository
    {
        string BaseRepository_ConnectionString { get; }
        IProjectDbContext BaseRepository_DbContext { get; }
    }
}