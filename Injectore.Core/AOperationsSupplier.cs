using System;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Interfaces;
using Injectore.Core.Models;
using Injectore.Core.Steps.CreateA;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core
{
    public abstract class AOperationsSupplier : IOperationsSupplier
    {
        protected readonly CreateStep1A _createStep1A;
        protected readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        protected readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        protected AOperationsSupplier(IServiceProvider service)
        {
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();
        }

        #region PIPELINE PROCEDURES

        public Func<IAggregate<CreateModel>, IAggregate<CreateModel>> CreatePipeline => PipeCreate;
        protected abstract IAggregate<CreateModel> PipeCreate(IAggregate<CreateModel> createAggregate);

        #endregion

        #region FUNCTIONS

        public Func<IAggregate<CreateModel>, IAggregate<CreateModel>> CalculateStocastic => FuncStocastic;
        protected abstract IAggregate<CreateModel> FuncStocastic(IAggregate<CreateModel> aggregate);

        #endregion
    }
}
