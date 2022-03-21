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

        protected override IAggregate<CreateModel> PipeCreate(IAggregate<CreateModel> aggregate)
        {
            aggregate = _createStep1A.AddSubStep(_createStep1A_SubStep1).AddSubStep(_createStep1A_SubStep2).Execute(aggregate);

            return aggregate;
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
