using System;
using System.ComponentModel.DataAnnotations;

namespace Injector.Data.Entities
{
    public class Entity : SoftDeleteEntity
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}