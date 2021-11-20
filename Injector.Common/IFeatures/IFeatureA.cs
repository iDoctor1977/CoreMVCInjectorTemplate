using Injector.Common.DTOModels;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA
    {
        OperetionResult<bool> CreatePost(DTOModelA dtoModelA);
        OperetionResult<DTOModelA> DeleteGet(DTOModelA dtoModelA);
        OperetionResult<bool> DeletePost(DTOModelA dtoModelA);
        OperetionResult<DTOModelA> EditGet(DTOModelA dtoModelA);
        OperetionResult<bool> EditPost(DTOModelA dtoModelA);
        OperetionResult<DTOModelA> DetailsGet(DTOModelA dtoModelA);
        OperetionResult<DTOModelA> ListGet(DTOModelA dtoModelA);
    }
}