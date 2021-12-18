using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;

namespace Injectore.Core.CaseDTOModels
{
    public class CaseDTOModelA : ABaseCaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>
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

        public void setId(int id)
        {
            _dtoModelA.Id = id;
            Consolidate();
        }

        public void setName (string name)
        {
            _dtoModelA.Name = name;
            Consolidate();
        }

        public void Consolidate()
        {
            if (IsModelValid())
            {
                
            }
        }

        public bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(_dtoModelA.Name);

            return value;
        }
    }
}