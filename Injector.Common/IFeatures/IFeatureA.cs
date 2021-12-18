using Injector.Common.DTOModels;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA
    {
        OperationResult<DTOModelA> CreateAndAddNewValueA(DTOModelA dtoModelA);
    }
}