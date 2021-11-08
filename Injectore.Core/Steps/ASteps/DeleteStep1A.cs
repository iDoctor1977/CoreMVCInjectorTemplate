using Injector.Common.DTOModels;

namespace Injector.Core.Steps.ASteps
{
    public class DeleteStep1A : ABaseStep<DTOModelA>
    {
        #region CONSTRUCTOR

        public DeleteStep1A() { }

        #endregion

        public override DTOModelA Execute(DTOModelA dtoModelA)
        {
            // Read

            // Do

            // Write

            if (NextStep != null)
            {
                dtoModelA = NextStep.Execute(dtoModelA);
            }

            return dtoModelA;
        }
    }
}