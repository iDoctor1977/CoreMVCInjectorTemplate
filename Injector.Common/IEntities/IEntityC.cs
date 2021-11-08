using System;

namespace Injector.Common.IEntities
{
    public interface IEntityC : ISoftDelete
    {
        int Id { get; set; }
        string Address { get; set; }
        string Cap { get; set; }
    }
}