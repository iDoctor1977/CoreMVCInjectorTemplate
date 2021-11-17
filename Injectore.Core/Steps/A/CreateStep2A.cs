using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Injector.Core.Steps.A
{
    public class CreateStep2A : BaseStep, ICreateStep2A<CaseDTOModelA>
    {
        public CreateStep2A(IServiceProvider service) : base(service) { }

        public void AddNode(string nodeName)
        {
            
        }

        public IEnumerable<string> GetRoot()
        {
            return Enumerable.Empty<string>();
        }

        public CaseDTOModelA Execute(CaseDTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            return dtoModelA;
        }
    }
}