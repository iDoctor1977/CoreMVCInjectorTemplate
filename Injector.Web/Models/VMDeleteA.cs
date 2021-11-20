using System.ComponentModel.DataAnnotations;

namespace Injector.Web.Models
{
    public class VMDeleteA 
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
    }
}