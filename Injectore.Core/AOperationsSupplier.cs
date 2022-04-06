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
        protected readonly CreateStep1 CreateStep1;
        protected readonly CreateStep1SubStep1 CreateStep1SubStep1;
        protected readonly CreateStep1SubStep2 CreateStep1SubStep2;

        protected readonly ReadStep1 ReadStep1;
        protected readonly ReadStep1SubStep1 ReadStep1SubStep1;

        protected AOperationsSupplier(IServiceProvider service)
        {
            CreateStep1 = service.GetRequiredService<CreateStep1>();
            CreateStep1SubStep1 = service.GetRequiredService<CreateStep1SubStep1>();
            CreateStep1SubStep2 = service.GetRequiredService<CreateStep1SubStep2>();

            ReadStep1 = service.GetRequiredService<ReadStep1>();
            ReadStep1SubStep1 = service.GetRequiredService<ReadStep1SubStep1>();
        }

        #region PIPELINE PROCEDURES

        public Func<CreateAggregate, CreateAggregate> ExecuteCreatePipeline => PipeCreate;
        protected abstract CreateAggregate PipeCreate(CreateAggregate aggregate);

        public Func<ReadAggregate, ReadAggregate> ExecuteReadPipeline => PipeRead;
        protected abstract ReadAggregate PipeRead(ReadAggregate aggregate);

        #endregion

        #region FUNCTIONS

        public Func<CreateAggregate, CreateAggregate> CalculateGuid => FuncCalculateGuid;
        protected abstract CreateAggregate FuncCalculateGuid(CreateAggregate aggregate);

        #endregion
    }
}
