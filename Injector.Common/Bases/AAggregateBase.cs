using System;
using Injector.Common.Models;
using Injector.Common.Resources;

namespace Injector.Common.Bases
{
    public abstract class AAggregateBase<T> where T : ABaseModel
    {
        protected readonly T Model;

        protected AAggregateBase(T model)
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
