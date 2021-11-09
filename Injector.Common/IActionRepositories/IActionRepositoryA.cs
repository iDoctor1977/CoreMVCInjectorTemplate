using Injector.Common.DTOModels;
using Injector.Common.IABases;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryA : IABaseActionRepository
    {
        bool CreateValue(DTOModelA dtoModelA);
        bool UpdateValue(DTOModelA dtoModelA);
        DTOModelA ReadValue(DTOModelA dtoModelA);
        bool DeleteValue(DTOModelA dtoModelA);
        IEnumerable<DTOModelA> ReadValues();
    }
}