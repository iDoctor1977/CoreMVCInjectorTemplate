using System;
using Injector.Common.Interfaces.IDepots;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.Read
{
    [Root]
    public class ReadStep1A : RootPipelineBuilder<ReadAggregate, ReadAggregate>
    {
        private readonly IReadDepot _readDepot;
        public ReadStep1A(IServiceProvider service)
        {
            _readDepot = service.GetRequiredService<IReadDepot>();
        }

        protected override ReadAggregate ExecuteRootStep(ReadAggregate aggregate)
        {
            // Read

            // Do

            // Write

            return aggregate;
        }
    }
}