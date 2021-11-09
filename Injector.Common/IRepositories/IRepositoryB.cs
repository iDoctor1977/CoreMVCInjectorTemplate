﻿using System;
using System.Collections.Generic;
using Injector.Common.IABases;
using Injector.Common.IEntities;

namespace Injector.Common.IRepositories
{
    public interface IRepositoryB : IABaseRepository
    {
        int CreateEntity(IEntityB entityB);
        bool UpdateEntity(IEntityB entityB);
        IEntityB ReadEntityById(int id);
        IEntityB ReadEntityByUsername(string username);
        IEnumerable<IEntityB> ReadEntities();
        bool DeleteEntity(IEntityB entityB);
    }
}