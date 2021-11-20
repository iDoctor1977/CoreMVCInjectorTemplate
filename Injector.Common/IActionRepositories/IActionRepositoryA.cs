using Injector.Common.DTOModels;
using Injector.Common.Enums;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryA
    {
        OperationResult<bool> CreateValue(DTOModelA dtoModelA);
        OperationResult<bool> UpdateValue(DTOModelA dtoModelA);
        OperationResult<DTOModelA> ReadValue(DTOModelA dtoModelA);
        OperationResult<bool> DeleteValue(DTOModelA dtoModelA);
        OperationResult<IEnumerable<DTOModelA>> ReadValues();
    }
}