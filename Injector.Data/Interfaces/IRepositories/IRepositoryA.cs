using System;
using Injector.Common.Models;

namespace Injector.Data.Interfaces.IRepositories
{
    public interface IRepositoryA
    {
        int CreateEntity(CreateRequestTransfertModel transfertModel);
        ReadResponseTransfertModel ReadEntityByGuid(Guid guid);
    }
}