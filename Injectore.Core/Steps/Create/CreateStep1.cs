using System;
using Injector.Common.Attributes;
using Injector.Common.Builders;
using Injector.Common.Interfaces.IDepots;
using Injectore.Core.Aggregates;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.Create
{
    [Root]
    public class CreateStep1 : RootPipelineBuilder<CreateAggregate, CreateAggregate>
    {
        private readonly ICreateDepot _createDepot;

        public CreateStep1(IServiceProvider service) {
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        protected override CreateAggregate ExecuteRootStep(CreateAggregate aggregate)
        {
            // Read
            var model = aggregate.ToModel();

            // Do
            _createDepot.Execute(model);

            // Write

            return aggregate;
        }
    }
}