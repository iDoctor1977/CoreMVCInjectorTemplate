using System;
using Injectore.Core.Aggregates;

namespace Injectore.Core
{
    public sealed class OperationsSupplier : AOperationsSupplier
    {
        public OperationsSupplier(IServiceProvider service) : base(service) { }

        #region PIPELINE PROCEDURES

        protected override CreateAggregate PipeCreate(CreateAggregate aggregate)
        {
            aggregate = CreateStep1.AddSubStep(CreateStep1SubStep1).AddSubStep(CreateStep1SubStep2).Execute(aggregate);

            return aggregate;
        }

        protected override ReadAggregate PipeRead(ReadAggregate aggregate)
        {
            aggregate = ReadStep1.AddSubStep(ReadStep1SubStep1).Execute(aggregate);

            return aggregate;
        }

        #endregion

        #region FUNCTIONS

        protected override CreateAggregate FuncCalculateGuid(CreateAggregate aggregate)
        {
            var a = Guid.NewGuid();

            aggregate.SetGuid(a);

            return aggregate;
        }

        #endregion
    }
}
