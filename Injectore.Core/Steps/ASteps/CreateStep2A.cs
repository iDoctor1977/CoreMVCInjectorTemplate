using Injector.Common.DTOModels;

namespace Injector.Core.Steps.ASteps
{
    public class CreateStep2A : ABaseStep<DTOModelA>
    {
        #region CONSTRUCTOR

        public CreateStep2A() { }

        #endregion

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}