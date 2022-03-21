using System;
using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Models;

namespace Injectore.Core.Interfaces
{
    public interface IOperationsSupplier
    {
        #region OPERATIONS

        public Func<IAggregate<CreateModel>, IAggregate<CreateModel>> CreatePipeline { get; }
        public Func<IAggregate<ReadModel>, IAggregate<ReadModel>> ReadPipeline { get; }

        #endregion

        #region FUNCTIONS

        public Func<IAggregate<CreateModel>, IAggregate<CreateModel>> CalculateStocastic { get; }

        #endregion
    }
}
