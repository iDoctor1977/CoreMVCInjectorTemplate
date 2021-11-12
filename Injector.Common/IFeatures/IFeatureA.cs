using Injector.Common.DTOModels;
using Injector.Common.IBases;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA
    {
        bool CreatePost(DTOModelA dtoModelA);
        DTOModelA DeleteGet(DTOModelA dtoModelA);
        bool DeletePost(DTOModelA dtoModelA);
        DTOModelA EditGet(DTOModelA dtoModelA);
        bool EditPost(DTOModelA dtoModelA);
        DTOModelA DetailsGet(DTOModelA dtoModelA);
        DTOModelA ListGet(DTOModelA dtoModelA);
    }
}