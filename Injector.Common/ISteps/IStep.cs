namespace Injector.Common.ISteps
{
    public interface IStep<T>
    {
        OperationResult<T> Execute(T caseDtoModel);
    }
}