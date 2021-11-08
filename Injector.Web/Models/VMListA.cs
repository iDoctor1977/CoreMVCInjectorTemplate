using Injector.Common.DTOModels;
using System.Collections.Generic;

namespace Injector.Web.Models
{
    public class VMListA
    {
        public IEnumerable<DTOModelA> ListDTOModelA { get; set; }
    }
}