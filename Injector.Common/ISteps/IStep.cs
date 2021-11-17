namespace Injector.Common.ISteps
{
    public interface IStep<T>
    {
        T Execute(T caseDtoModel);
    }
}