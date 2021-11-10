using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injector.Common
{
    public interface IPipelineStep<INPUT, OUTPUT>
    {
        OUTPUT Execute(INPUT input);
    }
}
