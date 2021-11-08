using Injector.Common.DTOModels;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep1A : ABaseStep<DTOModelA>
    {
        #region CONSTRUCTOR

        public CreateStep1A() { }

        #endregion

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do
            dtoModelA.Name = "pippo";

            // Write
            ABaseStep_CoreStoreInstance.CoreStore_DataSupplierInstance.GetActionRepositoryA.CreateValue(dtoModelA);

            if (NextStep != null)
            {
                dtoModelA = NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}