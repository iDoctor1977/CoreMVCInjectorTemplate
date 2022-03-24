using System;
using Injector.Common.Interfaces.IDepots;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.Create
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CreateAggregate, CreateAggregate>
    {
        private readonly ICreateDepot _createDepot;

        public CreateStep1A(IServiceProvider service) {
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        protected override CreateAggregate ExecuteRootStep(CreateAggregate aggregate)
        {
            // Read
            var model = aggregate.GetModel();

            // Do
            _createDepot.Execute(model);

            // Write

            return aggregate;
        }
    }
}