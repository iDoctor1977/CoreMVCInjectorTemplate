using Injector.Common.Models;

namespace Injector.Common.Interfaces.IFeatures
{
    public interface ICreateFeature
    {
        void CreateAndAddNewValueA(CreateRequestTransfertModel createRequestTM);
    }
}