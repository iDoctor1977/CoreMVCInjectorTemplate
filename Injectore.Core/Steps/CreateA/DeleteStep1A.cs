using System;
using Injector.Common.Interfaces.IAggregates;
using Injector.Common.Interfaces.IDepots;
using Injectore.Core.Attributes;
using Injectore.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.CreateA
{
    [Root]
    public class DeleteStep1A : RootPipelineBuilder<IAggregate<DeleteModel>, IAggregate<DeleteModel>>
    {
        private readonly IDeleteDepot _deleteDepot;
        public DeleteStep1A(IServiceProvider service)
        {
            _deleteDepot = service.GetRequiredService<IDeleteDepot>();
        }

        protected override IAggregate<DeleteModel> ExecuteRootStep(IAggregate<DeleteModel> aggregate)
        {
            // Read

            // Do

            // Write

            return aggregate;
        }
    }
}