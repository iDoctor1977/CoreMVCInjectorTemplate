using Injector.Common.DTOModels;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep1A : BaseStep<DTOModelA>
    {
        public CreateStep1A(ServiceProvider service) : base(service) { }

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do
            dtoModelA.Name = "pippo";

            // Write
            BaseStep_CoreStoreInstance.CoreStore_DataSupplierInstance.GetActionRepositoryA.CreateValue(dtoModelA);

            if (NextStep != null)
            {
                dtoModelA = NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}