using Injector.Common.DTOModels;
using System;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep1A : BaseStep
    {
        public CreateStep1A(IServiceProvider service) : base(service) { }

        public DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do
            dtoModelA.Name = "pippo";

            // Write
            BaseStep_DataSupplier.GetActionRepositoryA.CreateValue(dtoModelA);

            return dtoModelA;
        }
    }
}