using Injector.Common.Interfaces.IAggregates;
using Injectore.Core.Models;

namespace Injectore.Core.Aggregates
{
    public class ReadAggregate : ABaseAggregate<ReadModel>, IAggregate<ReadModel>
    {
        protected ReadModel ReadModel;

        public ReadAggregate(ReadModel readModel)
        {
            ReadModel = readModel;
        }

        public ReadModel GetModel()
        {
            ConsolidateModel();

            return ReadModel;
        }

        public void SetModel(ReadModel model)
        {
            ReadModel = model;
        }

        public void setId(int id)
        {
            ReadModel.Id = id;
            ConsolidateModel();
        }

        public void setName (string name)
        {
            ReadModel.Name = name;
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
            bool value = !string.IsNullOrWhiteSpace(ReadModel.Name);

            return value;
        }
    }
}