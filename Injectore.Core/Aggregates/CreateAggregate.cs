using System;
using Injector.Common.Interfaces.IAggregates;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public class CreateAggregate : ABaseAggregate<CreateModel>, IAggregate<CreateModel>
    {
        protected CreateModel CreateModel;

        public CreateAggregate(CreateModel createModel)
        {
            CreateModel = createModel;
        }

        public CreateModel GetModel()
        {
            ConsolidateModel();

            return CreateModel;
        }

        public void SetModel(CreateModel model)
        {
            CreateModel = model;
        }

        public void SetGuid(Guid guid)
        {
            CreateModel.GuId = guid;
            ConsolidateModel();
        }

        public void SetName (string name)
        {
            CreateModel.Name = name;
            ConsolidateModel();
        }

        public void ConsolidateModel()
        {
            if (IsModelValid())
            {
                
            }
        }

        public bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(CreateModel.Name);

            return value;
        }
    }
}