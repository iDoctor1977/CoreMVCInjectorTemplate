using Injector.Common.ISteps.B;
using Injector.Core.CaseDTOModels;
using System;

namespace Injector.Core.Steps.B
{
    public class CreateStep1B : BaseStep, ICreateStep1B<CaseDTOModelB>
    {
        public CreateStep1B(IServiceProvider service) : base(service) { }

        public CaseDTOModelB Execute(CaseDTOModelB caseDtoModelB)
        {
            // Read
            BaseStep_DataSupplier.GetActionRepositoryB.ReadValue(caseDtoModelB.GetDTOModel());

            // Do

            // Write
            BaseStep_DataSupplier.GetActionRepositoryB.CreateValue(caseDtoModelB.GetDTOModel());

            return caseDtoModelB;
        }
    }
}