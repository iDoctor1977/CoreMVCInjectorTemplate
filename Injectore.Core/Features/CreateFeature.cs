using System;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injectore.Core.Aggregates;
using Injectore.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Features
{
    public class CreateFeature : ICreateFeature
    {
        private readonly IOperationsSupplier _operationsSupplier;
        private readonly ICreateDepot _createDepot;

        public CreateFeature(IServiceProvider service) {
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        public void Execute(CreateModel model)
        {
            var aggregate = new CreateAggregate(model);

            // esempio di chiamata diretta al depot
            _createDepot.Execute(model);

            // esempio di chiamata a funzione procedurale con aggregato
            aggregate = _operationsSupplier.CreatePipeline(aggregate);

            // esempio di chiamata a funzione procedurale con model
            // aggregate = _operationsSupplier.CreatePipeline(model) as Model;

            // esempio di chiamata di funzione con aggregato
            _operationsSupplier.CalculateGuid(aggregate);

            // esempio di chiamata di funzione con model
            // _operationsSupplier.CalculateGuid(model) as Model;
        }
    }
}
