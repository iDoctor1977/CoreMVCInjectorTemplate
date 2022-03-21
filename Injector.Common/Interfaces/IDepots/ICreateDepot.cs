using Injector.Common.Interfaces.Features;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IDepots
{
    public interface ICreateDepot : ICqrsCommand<CreateRequestTransfertModel> { }
}