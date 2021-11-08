using Injector.Core.CaseDTOModels;
using Injector.Common.DTOModels;

namespace Injector.Core.CaseDTOModels
{
    public class CaseDTOModelA : ABaseCaseDTOModel<ABaseDTOModel>
    {
        protected DTOModelA dtoModelA;

        public CaseDTOModelA(DTOModelA dtoModelA)
        {
            this.dtoModelA = dtoModelA;
        }

        public void setName (string name)
        {
            dtoModelA.Name = name;
        }

        public void consolidate()
        {

        }

        #region PROTECTED

        protected bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(dtoModelA.Name);

            return value;
        }

        #endregion
    }
}