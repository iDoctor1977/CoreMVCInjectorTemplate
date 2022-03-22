using System;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Injectore.Core.Steps.Read;

namespace Injectore.Core.Steps.CreateA
{
    [Leaf(nameof(ReadStep1A))]
    public class ReadStep1A_SubStep1 : ISubStep<ReadAggregate, ReadAggregate>
    {
        public ReadStep1A_SubStep1(IServiceProvider service) { }

        public ReadAggregate Execute(ReadAggregate aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.IsModelValid();

            return aggregate;
        }
    }
}