using Injector.Common.DTOModels;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA
    {
        OperationResult<bool> CreatePost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DeleteGet(DTOModelA dtoModelA);
        OperationResult<bool> DeletePost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> EditGet(DTOModelA dtoModelA);
        OperationResult<bool> EditPost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DetailsGet(DTOModelA dtoModelA);
        OperationResult<DTOModelA> ListGet(DTOModelA dtoModelA);
    }
}