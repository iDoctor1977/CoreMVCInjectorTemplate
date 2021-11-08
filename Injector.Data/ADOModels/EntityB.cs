using System;
using System.ComponentModel.DataAnnotations;

namespace Injector.Data.ADOModels
{
    public class EntityB : SoftDelete
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
