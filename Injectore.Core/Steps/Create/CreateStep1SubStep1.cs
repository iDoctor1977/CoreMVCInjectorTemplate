using System;
using Injector.Common.Attributes;
using Injector.Common.Builders;
using Injectore.Core.Aggregates;

namespace Injectore.Core.Steps.Create
{
    [Leaf(nameof(CreateStep1))]
    public class CreateStep1SubStep1 : ISubStep<CreateAggregate, CreateAggregate>
    {
        public CreateStep1SubStep1(IServiceProvider service) { }

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