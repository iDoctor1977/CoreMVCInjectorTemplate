using System;
using Injectore.Core.Aggregates;

namespace Injectore.Core.Interfaces
{
    public interface IOperationsSupplier
    {
        #region OPERATIONS

        public Func<CreateAggregate, CreateAggregate> ExecuteCreatePipeline { get; }
        public Func<ReadAggregate, ReadAggregate> ExecuteReadPipeline { get; }

        #endregion

        #region FUNCTIONS

        public Func<CreateAggregate, CreateAggregate> CalculateGuid { get; }

        #endregion
    }
}
