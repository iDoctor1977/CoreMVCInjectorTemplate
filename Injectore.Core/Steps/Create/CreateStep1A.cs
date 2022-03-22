using System;
using AutoMapper;
using Injector.Common.Interfaces.IDepots;
using Injector.Common.Models;
using Injectore.Core.Aggregates;
using Injectore.Core.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.CreateA
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<CreateAggregate, CreateAggregate>
    {
        protected readonly IMapper _mapper;
        private readonly ICreateDepot _createDepot;

        public CreateStep1A(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        protected override CreateAggregate ExecuteRootStep(CreateAggregate aggregate)
        {
            // Read

            // Do
            var model = aggregate.GetModel();
            var transfertModel = _mapper.Map<CreateRequestTransfertModel>(model);

            _createDepot.Execute(transfertModel);

            // Write

            return aggregate;
        }
    }
}