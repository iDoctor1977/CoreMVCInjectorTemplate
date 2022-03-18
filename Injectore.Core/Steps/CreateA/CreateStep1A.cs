using System;
using Injector.Common.Interfaces.IActionRepositories;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Attributes;
using Injectore.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.CreateA
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<IAggregate<CreateModel>, IAggregate<CreateModel>>
    {
        private readonly ICreateDepot _createDepot;
        public CreateStep1A(IServiceProvider service) {
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        protected override IAggregate<CreateModel> ExecuteRootStep(IAggregate<CreateModel> aggregate)
        {
            // Read

            // Do
            var operationResult = _createDepot.CreateValue(aggregate.GetModel());

            // Write
            aggregate.SetModel(operationResult.Value);

            return aggregate;
        }
    }
}