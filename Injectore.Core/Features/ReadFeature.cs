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

        public ReadResponseTransfertModel Execute(ReadRequestTransfertModel transfertModel)
        {
            var model = _mapper.Map<ReadModel>(transfertModel);
            var aggregate = new ReadAggregate(model);

            // esempio di chiamata diretta al depot
            _readDepot.Execute(transfertModel);

            // esempio di chiamata a funzione procedurale con aggregato
            aggregate = _operationsSupplier.ReadPipeline(aggregate);

            // esempio di chiamata a funzione procedurale con model
            // readAggregate = _operationsSupplier.ReadPipeline(model) as ReadModel;

            // esempio di disaccopiamento (usata generalment con CqrsQuery)
            var responseTm = _mapper.Map<ReadResponseTransfertModel>(aggregate.GetModel());

            return responseTm;
        }
    }
}
