using System;

namespace Injector.Data.ADOModels
{
    public class SoftDelete
    {
        public bool IsDeleted { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
