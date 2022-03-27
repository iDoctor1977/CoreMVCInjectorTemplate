using System;
using Injector.Common.Models;
using Injector.Common.Resources;

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
                throw new ApplicationException($"{ErrorMessages.ABaseAggregate_ExceptionErrorString} EDF358B9-A42A-43F5-BAE4-5B67168D810A");
            }
        }

        public abstract T ToModel();
        protected abstract bool IsModelValid();
    }
}
