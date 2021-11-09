using Injector.Common.IDbContexts;

namespace Injector.Common.IABases
{
    public interface IABaseRepository
    {
        string ABaseRepository_ConnectionString { get; }
        IProjectDbContext ABaseRepository_DbContext { get; }
    }
}