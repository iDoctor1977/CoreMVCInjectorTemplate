using Injector.Common.DTOModels;

namespace Injector.Core.Steps.BSteps
{
    public class CreateStep1B : ABaseStep<DTOModelB>
    {
        #region CONSTRUCTOR

        public CreateStep1B() { }

        #endregion

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