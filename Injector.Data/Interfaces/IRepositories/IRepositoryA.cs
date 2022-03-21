using System.Collections.Generic;
using Injector.Common.Models;

namespace Injector.Data.Interfaces.IRepositories
{
    public interface IRepositoryA
    {
        int CreateEntity(CreateRequestTransfertModel transfertModel);
        int UpdateEntity(CreateRequestTransfertModel transfertModel);
        CreateResponseTransfertModel ReadEntityById(int id);
        CreateResponseTransfertModel ReadEntityByName(string name);
        int DeleteEntity(CreateRequestTransfertModel transfertModel);
        IEnumerable<CreateResponseTransfertModel> ReadEntities();
    }
}