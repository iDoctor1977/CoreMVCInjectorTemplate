namespace Injector.Common.Interfaces.IAggregates
{
    public interface IAggregate<T>
    {
        T GetModel();
        void SetModel(T createModel);
        void ConsolidateModel();
        bool IsModelValid();
    }
}
