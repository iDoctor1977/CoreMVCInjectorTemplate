using System;
using Injector.Common.Bases;
using Injector.Common.Models;

namespace Injectore.Core.Aggregates
{
    public class ReadAggregate : AAggregateBase<ReadModel>
    {
        public ReadAggregate(ReadModel model) : base(model) { }

        public void SetGuid(Guid guid)
        {
            Model.Guid = guid;
        }

        public void SetName (string name)
        {
            Model.Name = name;
        }

        public void SetSurname(string surname)
        {
            Model.Name = surname;
        }

        public void SetUpReadingDay()
        {
            Model.ReadingDay = DateTime.Today;
        }

        public override ReadModel ToModel()
        {
            return Model;
        }

        protected override bool IsModelValid()
        {
            bool value = !string.IsNullOrWhiteSpace(Model.Name);
            value = !string.IsNullOrWhiteSpace(Model.Surname);

            return value;
        }
    }
}