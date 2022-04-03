using System;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;

namespace Injectore.Core.Steps.Create
{
    [Leaf(nameof(CreateStep1))]
    public class CreateStep1SubStep2 : ISubStep<CreateAggregate, CreateAggregate>
    {
        public CreateStep1SubStep2(IServiceProvider service) { }

        public CreateAggregate Execute(CreateAggregate aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.ToModel();

            return aggregate;
        }
    }
}