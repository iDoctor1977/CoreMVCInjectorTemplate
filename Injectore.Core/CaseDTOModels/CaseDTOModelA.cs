using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injector.Core.CaseDTOModels
{
    public class CaseDTOModelA : ABaseCaseDTOModel<ABaseDTOModel>, ICaseDTOModel<DTOModelA>
    {
        protected DTOModelA dtoModelA;

        public CaseDTOModelA(DTOModelA dtoModelA)
        {
            this.dtoModelA = dtoModelA;
        }

        public DTOModelA GetDTOModel()
        {
            consolidate();

            return dtoModelA;
        }

        public void setName (string name)
        {
            dtoModelA.Name = name;
        }

        public void consolidate()
        {

        }

        public bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(dtoModelA.Name);

            return value;
        }
    }
}