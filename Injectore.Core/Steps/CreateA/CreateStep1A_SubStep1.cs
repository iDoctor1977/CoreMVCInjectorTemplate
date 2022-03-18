using System;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Attributes;
using Injectore.Core.Models;

namespace Injectore.Core.Steps.CreateA
{
    [Leaf(nameof(CreateStep1A))]
    public class CreateStep1A_SubStep1 : ISubStep<IAggregate<CreateModel>, IAggregate<CreateModel>>
    {
        public CreateStep1A_SubStep1(IServiceProvider service) { }

        public IAggregate<CreateModel> Execute(IAggregate<CreateModel> aggregate)
        {
            // Read

            // Do

            // Write
            aggregate.SetModel(null);

            return aggregate;
        }
    }
}