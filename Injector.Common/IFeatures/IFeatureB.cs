using Injector.Common.DTOModels;

namespace Injector.Common.IFeatures
{
    public interface IFeatureB
    {
        OperetionResult<bool> CreatePost(DTOModelB dtoModelB);
        OperetionResult<DTOModelB> DeleteGet(DTOModelB dtoModelB);
        OperetionResult<bool> DeletePost(DTOModelB dtoModelB);
        OperetionResult<DTOModelB> EditGet(DTOModelB dtoModelB);
        OperetionResult<bool> EditPost(DTOModelB dtoModelB);
        OperetionResult<DTOModelB> DetailsGet(DTOModelB dtoModelB);
        OperetionResult<DTOModelB> ListGet(DTOModelB dtoModelB);
    }
}