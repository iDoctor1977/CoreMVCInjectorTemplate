using Injector.Common.Models;

namespace Injector.Common.Interfaces.IActionRepositories
{
    public interface IDeleteDepot
    {
        DeleteResponseTransfertModel DeleteValue(DeleteRequestTransfertModel deleteRequestTM);
    }
}