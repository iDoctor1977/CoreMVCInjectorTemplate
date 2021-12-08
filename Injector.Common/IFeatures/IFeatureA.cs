using Injector.Common.DTOModels;
using Injector.Common.Enums;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA
    {
        OperationResult<DTOModelA> CreatePost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DeleteGet(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DeletePost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> EditGet(DTOModelA dtoModelA);
        OperationResult<DTOModelA> EditPost(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DetailsGet(DTOModelA dtoModelA);
        OperationResult<DTOModelA> ListGet(DTOModelA dtoModelA);
    }
}