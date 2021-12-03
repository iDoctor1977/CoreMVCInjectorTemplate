using Injector.Common.DTOModels;

namespace Injector.Common.IFeatures
{
    public interface IFeatureB
    {
        OperationResult<bool> CreatePost(DTOModelB dtoModelB);
        OperationResult<DTOModelB> DeleteGet(DTOModelB dtoModelB);
        OperationResult<bool> DeletePost(DTOModelB dtoModelB);
        OperationResult<DTOModelB> EditGet(DTOModelB dtoModelB);
        OperationResult<bool> EditPost(DTOModelB dtoModelB);
        OperationResult<DTOModelB> DetailsGet(DTOModelB dtoModelB);
        OperationResult<DTOModelB> ListGet(DTOModelB dtoModelB);
    }
}