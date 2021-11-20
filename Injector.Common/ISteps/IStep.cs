using Injector.Common.Enums;

namespace Injector.Common.ISteps
{
    public interface IStep<T>
    {
        OperationResult<T> Execute(OperationResult<T> caseDtoModel);
    }
}