using Injector.Common.Models;

namespace Injector.Common.Interfaces.IActionRepositories
{
    public interface ICreateDepot
    {
        int CreateValue(CreateRequestTransfertModel createRequestTM);
    }
}