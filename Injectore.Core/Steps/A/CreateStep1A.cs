using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;
using System.Collections.Generic;

namespace Injector.Core.Steps.A
{
    public class CreateStep1A : BaseStep, ICreateStep1A<CaseDTOModelA>
    {
        private List<string> root;

        public CreateStep1A(IServiceProvider service) : base(service) {
            root = new List<string>();
        }

        public void AddNode(string nodeName)
        {
            root.Add(nodeName);
        }

        public IEnumerable<string> GetRoot()
        {
            return root;
        }

        public CaseDTOModelA Execute(CaseDTOModelA caseDtoModelA)
        {
            // Read

            // Do
            caseDtoModelA.setName("pippo");

            // Write
            BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(caseDtoModelA.GetDTOModel());

            return caseDtoModelA;
        }
    }
}