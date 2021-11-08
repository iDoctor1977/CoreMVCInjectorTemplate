using Injector.Common.DTOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Steps.BSteps
{
    public class CreateStep1B : ABaseStep<DTOModelB>
    {
        public CreateStep1B(ServiceProvider service) : base(service) { }

        public override DTOModelB Execute(DTOModelB dtoModelB)
        {
            // Read
            dtoModelB = ABaseStep_CoreStoreInstance.CoreStore_DataSupplierInstance.GetActionRepositoryB.ReadValue(dtoModelB);

            // Do
            dtoModelB.Email = "pippo@gmail.com";

            // Write
            ABaseStep_CoreStoreInstance.CoreStore_DataSupplierInstance.GetActionRepositoryB.CreateValue(dtoModelB);

            if (NextStep != null)
            {
                dtoModelB = NextStep.Execute(dtoModelB);
            }

            return dtoModelB;
        }
    }
}