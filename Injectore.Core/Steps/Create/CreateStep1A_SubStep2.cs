using System;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;

namespace Injectore.Core.Steps.Create
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep2 : ISubStep<CreateAggregate, CreateAggregate>
    {
        public CreateStep1A_SubStep2(IServiceProvider service) { }

        public CreateAggregate Execute(CreateAggregate aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.IsModelValid();

            return aggregate;
        }
    }
}