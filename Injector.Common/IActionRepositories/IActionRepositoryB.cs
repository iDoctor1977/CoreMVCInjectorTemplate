using Injector.Common.DTOModels;
using Injector.Common.IBases;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryB : IBaseActionRepository
    {
        bool CreateValue(DTOModelB dtoModelB);
        bool UpdateValue(DTOModelB dtoModelB);
        DTOModelB ReadValue(DTOModelB dtoModelB);
        bool DeleteValue(DTOModelB dtoModelB);
        IEnumerable<DTOModelB> ReadValues();

    }
}