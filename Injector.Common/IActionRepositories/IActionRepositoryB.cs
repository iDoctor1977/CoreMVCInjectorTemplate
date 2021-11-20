using Injector.Common.DTOModels;
using Injector.Common.Enums;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryB
    {
        OperationResult<bool> CreateValue(DTOModelB dtoModelB);
        OperationResult<bool> UpdateValue(DTOModelB dtoModelB);
        OperationResult<DTOModelB> ReadValue(DTOModelB dtoModelB);
        OperationResult<bool> DeleteValue(DTOModelB dtoModelB);
        OperationResult<IEnumerable<DTOModelB>> ReadValues();
    }
}