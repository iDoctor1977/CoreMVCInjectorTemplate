using System;

namespace Injector.Data.Entities
{
    public class SoftDelete
    {
        public bool IsDeleted { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
