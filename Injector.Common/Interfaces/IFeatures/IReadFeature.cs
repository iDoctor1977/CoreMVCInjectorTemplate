using Injector.Common.Interfaces.Features;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IFeatures
{
    public interface IReadFeature : ICqrsQuery<ReadRequestTransfertModel, ReadResponseTransfertModel> { }
}