using System;
using Injectore.Core.Aggregates;

namespace Injectore.Core
{
    public class OperationsSupplier : AOperationsSupplier
    {
        public OperationsSupplier(IServiceProvider service) : base(service) { }

        #region PIPELINE PROCEDURES

        protected override CreateAggregate PipeCreate(CreateAggregate aggregate)
        {
            aggregate = _createStep1A.AddSubStep(_createStep1A_SubStep1).AddSubStep(_createStep1A_SubStep2).Execute(aggregate);

            return aggregate;
        }

        protected override ReadAggregate PipeRead(ReadAggregate aggregate)
        {
            aggregate = _readStep1A.AddSubStep(_readStep1A_SubStep1).Execute(aggregate);

            return aggregate;
        }

        #endregion

        #region FUNCTIONS

        protected override CreateAggregate FuncCalculateGuid(CreateAggregate aggregate)
        {
            if (aggregate is CreateAggregate createAggregate)
            {
                var a = Guid.NewGuid();

                createAggregate.SetGuid(a);
            }

            return aggregate;
        }

        #endregion
    }
}
