using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntities;

namespace Injector.Data.ADOModels
{
    public class EntityA : SoftDelete
    {
        // relazione 1 * M
        public EntityA()
        {
            colEntitiesC = new List<EntityC>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // collection navigation property
        public ICollection<EntityC> colEntitiesC { get; set; }
    }
}