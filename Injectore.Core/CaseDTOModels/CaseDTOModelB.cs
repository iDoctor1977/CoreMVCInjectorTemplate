using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injector.Core.CaseDTOModels
{
    public class CaseDTOModelB : ABaseCaseDTOModel<ABaseDTOModel>, ICaseDTOModel<DTOModelB>
    {
        protected DTOModelB dtoModelB;

        public CaseDTOModelB(DTOModelB dtoModelB)
        {
            this.dtoModelB = dtoModelB;
        }

        public void consolidate()
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB GetDTOModel()
        {
            return dtoModelB;
        }

        public bool IsModelValid()
        {
            throw new System.NotImplementedException();
        }

        public void setName (string username)
        {
            dtoModelB.Username = username;
        }
    }
}