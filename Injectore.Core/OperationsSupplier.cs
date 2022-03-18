using System;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Aggregates;
using Injectore.Core.Models;

namespace Injectore.Core
{
    public class OperationsSupplier : AOperationsSupplier
    {
        public OperationsSupplier(IServiceProvider service) : base(service) { }

        #region PIPELINE PROCEDURES

        protected override IAggregate<CreateModel> PipeCreate(IAggregate<CreateModel> createAggregate)
        {
            createAggregate = _createStep1A.AddStep(_createStep1A_SubStep1).AddStep(_createStep1A_SubStep2).Execute(createAggregate);

            return createAggregate;
        }

        #endregion

        #region FUNCTIONS

        protected override IAggregate<CreateModel> FuncStocastic(IAggregate<CreateModel> aggregate)
        {
            if (aggregate is CreateAggregate createAggregate)
            {
                var a = 1 + 2 + 3;

                createAggregate.setId(a);
            }

            return aggregate;
        }

        #endregion
    }
}
