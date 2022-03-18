using System;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Attributes;
using Injectore.Core.Models;

namespace Injectore.Core.Steps.CreateA
{
    [Leaf(nameof(DeleteStep1A))]
    public class DeleteStep1A_SubStep1 : ISubStep<IAggregate<DeleteModel>, IAggregate<DeleteModel>>
    {
        public DeleteStep1A_SubStep1(IServiceProvider service) { }

        public IAggregate<DeleteModel> Execute(IAggregate<DeleteModel> aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.SetModel(null);

            return aggregate;
        }
    }
}