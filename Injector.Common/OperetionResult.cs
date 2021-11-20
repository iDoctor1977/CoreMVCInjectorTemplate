using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injector.Common
{
    public class OperetionResult<T>
    {
        public T Value { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
