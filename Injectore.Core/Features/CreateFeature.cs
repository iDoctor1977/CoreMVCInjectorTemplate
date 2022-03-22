﻿using System;
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

        public void Execute(CreateRequestTransfertModel transfertModel)
        {
            var model = _mapper.Map<CreateModel>(transfertModel);
            var aggregate = new CreateAggregate(model);

            // esempio di chiamata diretta al depot
            _createDepot.Execute(transfertModel);

            // esempio di chiamata a funzione procedurale con aggregato
            aggregate = _operationsSupplier.CreatePipeline(aggregate) as CreateAggregate;

            // esempio di chiamata a funzione procedurale con model
            // createAggregate = _operationsSupplier.CreatePipeline(model) as CreateModel;

            // esempio di chiamata a funzione con aggregato
            aggregate = _operationsSupplier.CalculateStocastic(aggregate) as CreateAggregate;

            // esempio di chiamata a funzione con model
            // createAggregate = _operationsSupplier.CalculateStocastic(model) as CreateModel;
        }
    }
}
