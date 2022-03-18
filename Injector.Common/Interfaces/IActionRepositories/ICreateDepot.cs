using Injector.Common.Models;

namespace Injector.Common.Interfaces.IActionRepositories
{
    public interface ICreateDepot
    {
        CreateResponseTransfertModel CreateValue(CreateRequestTransfertModel createRequestTM);
    }
}