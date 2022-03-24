using System;
using AutoMapper;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.Read
{
    [Root]
    public class ReadStep1A : RootPipelineBuilder<ReadAggregate, ReadAggregate>
    {
        protected readonly IMapper _mapper;
        private readonly IReadDepot _readDepot;

        public ReadStep1A(IServiceProvider service)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _readDepot = service.GetRequiredService<IReadDepot>();
        }

        protected override ReadAggregate ExecuteRootStep(ReadAggregate aggregate)
        {
            // Read
            var model = aggregate.GetModel();

            // Do
            var responseTransfertModel = _readDepot.Execute(model);

            // Write
            var modelResponse = _mapper.Map<ReadModel>(responseTransfertModel);
            aggregate.SetModel(modelResponse);

            return aggregate;
        }
    }
}