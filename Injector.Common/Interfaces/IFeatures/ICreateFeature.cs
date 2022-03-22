using Injector.Common.Interfaces.ICqrs;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IFeatures
{
    public interface ICreateFeature : ICqrsCommand<CreateRequestTransfertModel> { }
}