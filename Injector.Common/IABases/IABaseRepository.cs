using Injector.Common.IDbContexts;

namespace Injector.Common.IABases
{
    public interface IABaseRepository
    {
        string ConnectionStringName { get; set; }
    }
}