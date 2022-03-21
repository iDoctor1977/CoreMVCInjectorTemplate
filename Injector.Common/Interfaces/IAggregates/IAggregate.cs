namespace Injector.Common.Interfaces.IAggregates
{
    public interface IAggregate<T>
    {
        T GetModel();
        void SetModel(T readModel);
        void ConsolidateModel();
        bool IsModelValid();
    }
}
