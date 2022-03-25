namespace Injectore.Core.Aggregates
{
    public abstract class ABaseAggregate<T>
    {
        public T Model { get; set; }

        protected ABaseAggregate(T model)
        {
            Model = model;
        }

        protected abstract void ConsolidateModel();
        public abstract bool IsModelValid();
    }
}
