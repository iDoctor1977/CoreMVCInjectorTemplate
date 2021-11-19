using Injector.Common.ISteps.A;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.A
{
    public class CreateStep1A : BaseStep, ICreateStep1A<CaseDTOModelA>
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        public CaseDTOModelA Execute(CaseDTOModelA caseDtoModelA)
        {
            // Read

            // Do

            // Write

            if (BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(caseDtoModelA.GetDTOModel()))
            {
                return caseDtoModelA;
            }

            throw new System.NotImplementedException();
        }
    }
}