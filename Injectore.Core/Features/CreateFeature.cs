using System;
using AutoMapper;
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

        public CreateFeature(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
        }

        public CreateResponseTransfertModel CreateAndAddNewValueA(CreateRequestTransfertModel createRequestTM)
        {
            var createModel = _mapper.Map<CreateModel>(createRequestTM);
            var createAggregate = new CreateAggregate(createModel);

            // esempio di chiamata a funzione
            createAggregate = _operationsSupplier.CalculateStocastic(createAggregate) as CreateAggregate;

            // esempio di chiamata a funzione procedurale
            createAggregate = _operationsSupplier.CreatePipeline(createAggregate) as CreateAggregate;

            var createResponseTM = _mapper.Map<CreateResponseTransfertModel>(createAggregate.GetModel());

            return createResponseTM;
        }
    }
}
