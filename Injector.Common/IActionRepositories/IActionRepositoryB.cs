using Injector.Common.DTOModels;
using Injector.Common.IABases;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryB : IABaseActionRepository
    {
        bool CreateValue(DTOModelB dtoModelB);
        bool UpdateValue(DTOModelB dtoModelB);
        DTOModelB ReadValue(DTOModelB dtoModelB);
        bool DeleteValue(DTOModelB dtoModelB);
        IEnumerable<DTOModelB> ReadValues();

    }
}