using Injector.Common.IBases;
using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Steps
{
    public class BaseStep<T> : IBaseStep<T>
    {
        private readonly IDataSupplier _dataSupplier;

        public BaseStep(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
        }

        public IDataSupplier BaseStep_DataSupplier => _dataSupplier;

        internal IBaseStep<T> NextStep { get; private set; }

        public void SetNextStep(IBaseStep<T> nextStep)
        {
            NextStep = nextStep;
        }

        public virtual T Execute(T dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}