using Injector.Core.CaseDTOModels;
using Injector.Common.DTOModels;

namespace Injector.Core.CaseDTOModels
{
    public class CaseDTOModelB : ABaseCaseDTOModel<ABaseDTOModel>
    {
        protected DTOModelB dtoModelB;

        public CaseDTOModelB(DTOModelB dtoModelB)
        {
            this.dtoModelB = dtoModelB;
        }

        public void setName (string username)
        {
            dtoModelB.Username = username;
        }

        public void consolidate()
        {

        }

        #region PROTECTED

        protected bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(dtoModelB.Username);

            return value;
        }

        #endregion
    }
}