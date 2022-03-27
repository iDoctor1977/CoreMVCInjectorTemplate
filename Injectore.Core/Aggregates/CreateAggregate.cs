using System;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public class CreateAggregate : ABaseAggregate<CreateModel>
    {
        public CreateAggregate(CreateModel model) : base(model) { }

        public void SetGuid(Guid guid)
        {
            Model.Guid = guid;
        }

        public void SetName (string name)
        {
            Model.Name = name;
        }
        public void SetSurame (string surname)
        {
            Model.Surname = surname;
        }

        public override CreateModel ToModel()
        {
            return Model;
        }

        protected override bool IsModelValid()
        {
            var value = !string.IsNullOrWhiteSpace(Model.Name);
            value = !string.IsNullOrWhiteSpace(Model.Surname);

            return value;
        }
    }
}