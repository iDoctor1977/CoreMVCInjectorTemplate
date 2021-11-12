using Injector.Common.DTOModels;
using Injector.Common.IBases;

namespace Injector.Common.IFeatures
{
    public interface IFeatureB
    {
        bool CreatePost(DTOModelB dtoModelB);
        DTOModelB DeleteGet(DTOModelB dtoModelB);
        bool DeletePost(DTOModelB dtoModelB);
        DTOModelB EditGet(DTOModelB dtoModelB);
        bool EditPost(DTOModelB dtoModelB);
        DTOModelB DetailsGet(DTOModelB dtoModelB);
        DTOModelB ListGet(DTOModelB dtoModelB);
    }
}