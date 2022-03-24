using Injector.Common.Interfaces.ICqrs;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IFeatures
{
    public interface IReadFeature : ICqrsQuery<ReadModel, ReadModel> { }
}