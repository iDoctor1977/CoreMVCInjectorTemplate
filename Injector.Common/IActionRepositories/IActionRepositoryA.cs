using Injector.Common.DTOModels;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryA
    {
        OperationResult<DTOModelA> CreateValue(DTOModelA dtoModelA);
        OperationResult<DTOModelA> UpdateValue(DTOModelA dtoModelA);
        OperationResult<DTOModelA> ReadValue(DTOModelA dtoModelA);
        OperationResult<DTOModelA> DeleteValue(DTOModelA dtoModelA);
        OperationResult<IEnumerable<DTOModelA>> ReadValues();
    }
}