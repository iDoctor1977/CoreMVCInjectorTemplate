using Injector.Common.IBases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Steps
{
    public class BaseStep<T> : IBaseStep<T>
    {
        internal IBaseStep<T> NextStep { get; private set; }

        public BaseStep(IServiceProvider service)
        {
            service.GetRequiredService(typeof(IBaseStep<>));
        }

        public ICoreStore BaseStep_CoreStoreInstance => BaseStep_CoreStoreInstance;

        public void SetNextStep(IBaseStep<T> nextStep)
        {
            NextStep = nextStep;
        }

        public virtual T Execute(T dtoModelA)
        {
            throw new System.NotImplementedException();
        }
    }
}