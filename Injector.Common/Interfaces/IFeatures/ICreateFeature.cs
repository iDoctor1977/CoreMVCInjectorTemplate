using Injector.Common.Models;

namespace Injector.Common.Interfaces.IFeatures
{
    public interface ICreateFeature
    {
        CreateResponseTransfertModel CreateAndAddNewValueA(CreateRequestTransfertModel createRequestTM);
    }
}