using System;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public class CreateAggregate : ABaseAggregate<CreateModel>
    {
        public CreateAggregate(CreateModel model) : base(model) { }

        public void SetGuid(Guid guid)
        {
            Model.GuId = guid;
            ConsolidateModel();
        }

        public void SetName (string name)
        {
            Model.Name = name;
            ConsolidateModel();
        }
        public void SetSurame (string surname)
        {
            Model.Surname = surname;
            ConsolidateModel();
        }

        protected override void ConsolidateModel()
        {
            if (IsModelValid())
            {
                
            }
        }

        public override bool IsModelValid()
        {
            var value = !string.IsNullOrWhiteSpace(Model.Name);
            value = !string.IsNullOrWhiteSpace(Model.Surname);

            return value;
        }
    }
}