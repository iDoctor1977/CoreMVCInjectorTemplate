using System;
using AutoMapper;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injectore.Core.Aggregates;
using Injectore.Core.Interfaces;
using Injectore.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Features
{
    public class CreateFeature : ICreateFeature
    {
        private readonly IMapper _mapper;
        private readonly IOperationsSupplier _operationsSupplier;
        private readonly ICreateDepot _createDepot;

        public CreateFeature(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        public void Execute(CreateRequestTransfertModel model)
        {
            var createModel = _mapper.Map<CreateModel>(model);
            var createAggregate = new CreateAggregate(createModel);

            // esempio di chiamata diretta al depot
            _createDepot.Execute(model);

            // esempio di chiamata a funzione procedurale con aggregato
            createAggregate = _operationsSupplier.CreatePipeline(createAggregate) as CreateAggregate;

            // esempio di chiamata a funzione procedurale con model
            // createAggregate = _operationsSupplier.CreatePipeline(model) as CreateModel;

            // esempio di chiamata a funzione con aggregato
            createAggregate = _operationsSupplier.CalculateStocastic(createAggregate) as CreateAggregate;

            // esempio di chiamata a funzione con model
            // createAggregate = _operationsSupplier.CalculateStocastic(model) as CreateModel;

            // esempio di disaccopiamento (usata generalment con CqrsQuery)
            // var createResponseTM = _mapper.Map<ReadResponseTransfertModel>(createAggregate.GetModel());
        }
    }
}
