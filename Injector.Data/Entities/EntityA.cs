using System.ComponentModel.DataAnnotations;

namespace Injector.Data.Entities
{
    public class EntityA : SoftDelete
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}