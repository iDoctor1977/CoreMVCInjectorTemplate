using Injector.Common.DTOModels;

namespace Injector.Core.Steps.BSteps
{
    public class CreateStep2B : ABaseStep<DTOModelB>
    {
        #region CONSTRUCTOR

        public CreateStep2B() { }

        #endregion

        public override DTOModelB Execute(DTOModelB dtoModelB)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(dtoModelB);
            }

            return dtoModelB;
        }
    }
}