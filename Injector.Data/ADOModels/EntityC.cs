using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Injector.Data.ADOModels
{
    public class EntityC : SoftDelete
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Cap { get; set; }

        [ForeignKey("extEntitiesA")]
        public int IdA { get; set; }

        // collection navigation property
        public EntityA extEntitiesA { get; set; }

    }
}