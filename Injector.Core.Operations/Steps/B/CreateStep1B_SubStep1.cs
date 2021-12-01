using Injector.Common;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Operator.Steps.B
{
    [Leaf(nameof(CreateStep1B))]
    public class CreateStep1B_SubStep1 : BaseStep, ISubStep<OperationResult<CaseDTOModelB>, OperationResult<CaseDTOModelB>>
    {
        public CreateStep1B_SubStep1(IServiceProvider service) : base(service) { }

        public OperationResult<CaseDTOModelB> Execute(OperationResult<CaseDTOModelB> value)
        {
            // Read

            // Do

            // Write

            return value;
        }
    }
}