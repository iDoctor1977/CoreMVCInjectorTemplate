using System;
using AutoMapper;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injectore.Core.Aggregates;
using Injectore.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Features
{
    public class ReadFeature : IReadFeature
    {
        private readonly IMapper _mapper;
        private readonly IOperationsSupplier _operationsSupplier;
        private readonly IReadDepot _readDepot;

        public ReadFeature(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
            _readDepot = service.GetRequiredService<IReadDepot>();
        }

        public ReadModel Execute(ReadModel model)
        {
            var aggregate = new ReadAggregate(model);

            // esempio di chiamata diretta al depot
            _readDepot.Execute(model);

            // esempio di chiamata a funzione procedurale con aggregato
            aggregate = _operationsSupplier.ExecuteReadPipeline(aggregate);

            // esempio di chiamata a funzione procedurale con model
            // readAggregate = _operationsSupplier.ExecuteReadPipeline(model) as ReadModel;

            aggregate.SetUpReadingDay();

            // esempio di disaccopiamento (usata generalment con CqrsQuery)
            var responseModel = _mapper.Map<ReadModel>(aggregate.ToModel());

            return responseModel;
        }
    }
}
