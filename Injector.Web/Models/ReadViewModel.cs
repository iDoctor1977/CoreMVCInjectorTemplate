using System;
using System.ComponentModel.DataAnnotations;

namespace Injector.Web.Models
{
    public class ReadViewModel
    {
        [ScaffoldColumn(false)]
        public Guid GuId { get; set; }

        [Display(Name = "Numero di telefono")]
        [DataType(DataType.Text)]
        public string TelNumber { get; set; }

        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Cognome")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [DataType(DataType.Text)]
        public string ReadingDay { get; set; }
    }
}