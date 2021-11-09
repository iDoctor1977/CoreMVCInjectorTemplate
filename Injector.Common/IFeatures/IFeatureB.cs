using Injector.Common.DTOModels;
using Injector.Common.IABases;

namespace Injector.Common.IFeatures
{
    public interface IFeatureB : IABaseFeature
    {
        #region STEPS

        IABaseStep<DTOModelB> CreateStep1B { get; }
        IABaseStep<DTOModelB> CreateStep2B { get; }
        IABaseStep<DTOModelB> CreateStep3B { get; }

        #endregion

        bool CreatePost(DTOModelB dtoModelB);
        DTOModelB DeleteGet(DTOModelB dtoModelB);
        bool DeletePost(DTOModelB dtoModelB);
        DTOModelB EditGet(DTOModelB dtoModelB);
        bool EditPost(DTOModelB dtoModelB);
        DTOModelB DetailsGet(DTOModelB dtoModelB);
        DTOModelB ListGet(DTOModelB dtoModelB);
    }
}