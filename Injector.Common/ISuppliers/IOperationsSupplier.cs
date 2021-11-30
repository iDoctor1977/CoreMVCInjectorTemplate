using Injector.Common.DTOModels;
using Injector.Common.ICaseDTOModels;
using System;

namespace Injector.Common.ISuppliers
{
    public interface IOperationsSupplier
    {
        public Func<ICaseDTOModel<DTOModelA>, ICaseDTOModel<DTOModelA>> CreateValueA { get; }
    }
}
