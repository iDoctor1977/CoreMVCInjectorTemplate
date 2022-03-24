using System;
using Injector.Common.Models;

namespace Injector.Data.Interfaces.IRepositories
{
    public interface IRepositoryA
    {
        int CreateEntity(CreateModel model);
        ReadModel ReadEntityByGuid(Guid guid);
    }
}