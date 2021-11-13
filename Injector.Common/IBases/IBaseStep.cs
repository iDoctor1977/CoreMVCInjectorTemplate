namespace Injector.Common.IBases
{
    public interface IBaseStep<T>
    {
        void SetNextStep(IBaseStep<T> step);
        T Execute(T dtoModelA);
    }
}