using System;
using Injectore.Core.Aggregates;
using Injectore.Core.Interfaces;
using Injectore.Core.Steps.Create;
using Injectore.Core.Steps.Read;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core
{
    public abstract class AOperationsSupplier : IOperationsSupplier
    {
        protected readonly CreateStep1A _createStep1A;
        protected readonly CreateStep1A_SubStep1 _createStep1A_SubStep1;
        protected readonly CreateStep1A_SubStep2 _createStep1A_SubStep2;

        protected readonly ReadStep1A _readStep1A;
        protected readonly ReadStep1A_SubStep1 _readStep1A_SubStep1;

        protected AOperationsSupplier(IServiceProvider service)
        {
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep1A_SubStep1 = service.GetRequiredService<CreateStep1A_SubStep1>();
            _createStep1A_SubStep2 = service.GetRequiredService<CreateStep1A_SubStep2>();

            _readStep1A = service.GetRequiredService<ReadStep1A>();
            _readStep1A_SubStep1 = service.GetRequiredService<ReadStep1A_SubStep1>();
        }

        #region PIPELINE PROCEDURES

        public Func<CreateAggregate, CreateAggregate> CreatePipeline => PipeCreate;
        protected abstract CreateAggregate PipeCreate(CreateAggregate aggregate);

        public Func<ReadAggregate, ReadAggregate> ReadPipeline => PipeRead;
        protected abstract ReadAggregate PipeRead(ReadAggregate aggregate);

        #endregion

        #region FUNCTIONS

        public Func<CreateAggregate, CreateAggregate> CalculateStocastic => FuncCalculateGuid;
        protected abstract CreateAggregate FuncCalculateGuid(CreateAggregate aggregate);

        #endregion
    }
}
