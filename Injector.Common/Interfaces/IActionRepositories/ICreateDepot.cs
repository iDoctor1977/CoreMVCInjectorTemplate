using Injector.Common.Interfaces.Features;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IActionRepositories
{
    public interface ICreateDepot : ICqrsCommand<CreateRequestTransfertModel> { }
}