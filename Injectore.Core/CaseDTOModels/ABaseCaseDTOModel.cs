using Injector.Common.DTOModels;

namespace Injector.Core.CaseDTOModels
{
    public abstract class ABaseCaseDTOModel<T> where T : ABaseDTOModel
    {
        protected T dtoModel;
    }
}
