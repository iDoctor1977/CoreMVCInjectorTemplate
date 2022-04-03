using System;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;

namespace Injectore.Core.Steps.Read
{
    [Leaf(nameof(ReadStep1))]
    public class ReadStep1SubStep1 : ISubStep<ReadAggregate, ReadAggregate>
    {
        public ReadStep1SubStep1(IServiceProvider service) { }

        public ReadAggregate Execute(ReadAggregate aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.ToModel();

            return aggregate;
        }
    }
}