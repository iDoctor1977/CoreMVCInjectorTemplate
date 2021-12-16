using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injectore.Core.CaseDTOModels
{
    public class CaseDTOModelA : ABaseCaseDTOModel<ABaseDTOModel>, ICaseDTOModel<DTOModelA>
    {
        protected DTOModelA _dtoModelA;

        public CaseDTOModelA(DTOModelA dtoModelA)
        {
            this._dtoModelA = dtoModelA;
        }

        public DTOModelA GetDTOModel()
        {
            Consolidate();

            return _dtoModelA;
        }

        public void SetDTOModel(DTOModelA dtoModel)
        {
            _dtoModelA = dtoModel;
        }

        public void setName (string name)
        {
            _dtoModelA.Name = name;
        }

        public void Consolidate()
        {

        }

        public bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(_dtoModelA.Name);

            return value;
        }
    }
}