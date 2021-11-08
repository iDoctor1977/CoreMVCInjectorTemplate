﻿using Injector.Common.DTOModels;
using System.Collections.Generic;

namespace Injector.Common.IActionRepositories
{
    public interface IActionRepositoryB
    {
        bool CreateValue(DTOModelB dtoModelB);
        bool UpdateValue(DTOModelB dtoModelB);
        DTOModelB ReadValue(DTOModelB dtoModelB);
        bool DeleteValue(DTOModelB dtoModelB);
        IEnumerable<DTOModelB> ReadValues();

    }
}