using Injector.Common.DTOModels;
using Injector.Common.IABases;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA : IABaseFeature
    {
        #region STEPS

        IABaseStep<DTOModelA> CreateStep1A { get; }
        IABaseStep<DTOModelA> CreateStep2A { get; }
        IABaseStep<DTOModelA> CreateStep3A { get; }

        IABaseStep<DTOModelA> DeleteStep1A { get; }
        IABaseStep<DTOModelA> DeleteStep2A { get; }

        #endregion

        bool CreatePost(DTOModelA dtoModelA);
        DTOModelA DeleteGet(DTOModelA dtoModelA);
        bool DeletePost(DTOModelA dtoModelA);
        DTOModelA EditGet(DTOModelA dtoModelA);
        bool EditPost(DTOModelA dtoModelA);
        DTOModelA DetailsGet(DTOModelA dtoModelA);
        DTOModelA ListGet(DTOModelA dtoModelA);
    }
}