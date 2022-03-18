using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Models;

namespace Injectore.Core.Aggregates
{
    public class CreateAggregate : ABaseAggregate<CreateModel>, IAggregate<CreateModel>
    {
        protected CreateModel CreateModel;

        public CreateAggregate(CreateModel createModel)
        {
            this.CreateModel = createModel;
        }

        public CreateModel GetModel()
        {
            ConsolidateModel();

            return CreateModel;
        }

        public void SetModel(CreateModel createModel)
        {
            CreateModel = createModel;
        }

        public void setId(int id)
        {
            CreateModel.Id = id;
            ConsolidateModel();
        }

        public void setName (string name)
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