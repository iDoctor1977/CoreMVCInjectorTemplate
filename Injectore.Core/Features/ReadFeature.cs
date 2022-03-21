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

        public ReadResponseTransfertModel Execute(ReadRequestTransfertModel model)
        {
            var readModel = _mapper.Map<ReadModel>(model);
            var readAggregate = new ReadAggregate(readModel);

            // esempio di chiamata diretta al depot
            _readDepot.Execute(model);

            // esempio di chiamata a funzione procedurale con aggregato
            readAggregate = _operationsSupplier.ReadPipeline(readAggregate) as ReadAggregate;

            // esempio di chiamata a funzione procedurale con model
            // readAggregate = _operationsSupplier.ReadPipeline(model) as ReadModel;

            // esempio di disaccopiamento (usata generalment con CqrsQuery)
            var responseTM = _mapper.Map<ReadResponseTransfertModel>(readAggregate.GetModel());

            return responseTM;
        }
    }
}
