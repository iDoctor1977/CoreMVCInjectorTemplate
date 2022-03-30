using System;

namespace Injector.Common.Models
{
    public class ReadModel : ABaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ReadingDay { get; set; }
    }
}