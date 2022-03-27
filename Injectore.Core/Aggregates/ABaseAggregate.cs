using System;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public abstract class ABaseAggregate<T> where T : ABaseModel
    {
        protected readonly T Model;

        protected ABaseAggregate(T model)
        {
            Model = model;

            if (!IsModelValid())
            {
                throw new ApplicationException("Invalid model { EDF358B9-A42A-43F5-BAE4-5B67168D810A }");
            }
        }

        public abstract T ConsolidateModel();
        protected abstract bool IsModelValid();
    }
}
