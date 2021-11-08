using Injector.Common.DTOModels;

namespace Injector.Core.Steps.ASteps
{
    public class DeleteStep2A : ABaseStep<DTOModelA>
    {
        #region CONSTRUCTOR

        public DeleteStep2A() { }

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