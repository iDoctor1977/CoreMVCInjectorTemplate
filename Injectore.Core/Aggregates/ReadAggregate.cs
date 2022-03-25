using System;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public class ReadAggregate : ABaseAggregate<ReadModel>
    {
        public ReadAggregate(ReadModel model) : base(model) { }

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

        public void SetSurname(string surname)
        {
            Model.Name = surname;
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
            bool value = !string.IsNullOrWhiteSpace(Model.Name);
            value = !string.IsNullOrWhiteSpace(Model.Surname);

            return value;
        }
    }
}