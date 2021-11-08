using System;

namespace Injector.Common.IEntities
{
    public interface IEntityA : ISoftDelete
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}