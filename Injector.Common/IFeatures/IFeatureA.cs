using Injector.Common.DTOModels;
using Injector.Common.IBases;

namespace Injector.Common.IFeatures
{
    public interface IFeatureA : IBaseFeature
    {
        #region STEPS

        IBaseStep<DTOModelA> CreateStep1A { get; }
        IBaseStep<DTOModelA> CreateStep2A { get; }
        IBaseStep<DTOModelA> CreateStep3A { get; }

        IBaseStep<DTOModelA> DeleteStep1A { get; }
        IBaseStep<DTOModelA> DeleteStep2A { get; }

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