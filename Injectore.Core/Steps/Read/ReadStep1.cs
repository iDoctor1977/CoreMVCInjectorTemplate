using System;
using Injector.Common.Interfaces.IDepots;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.Read
{
    [Root]
    public class ReadStep1 : RootPipelineBuilder<ReadAggregate, ReadAggregate>
    {
        private readonly IReadDepot _readDepot;

        public ReadStep1(IServiceProvider service)
        {
            _readDepot = service.GetRequiredService<IReadDepot>();
        }

        protected override ReadAggregate ExecuteRootStep(ReadAggregate aggregate)
        {
            // Read
            var model = aggregate.ToModel();

            // Do

            var resultModel = _readDepot.Execute(model);
            var resultAggregate = new ReadAggregate(resultModel);

            // Write

            return resultAggregate;
        }
    }
}