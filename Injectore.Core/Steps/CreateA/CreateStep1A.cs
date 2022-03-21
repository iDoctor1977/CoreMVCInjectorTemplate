using System;
using AutoMapper;
using Injector.Common.Interfaces.IActionRepositories;
using Injector.Common.Interfaces.IAggregates;
using Injector.Common.Models;
using Injectore.Core.Attributes;
using Injectore.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Injectore.Core.Steps.CreateA
{
    [Root]
    public class CreateStep1A : RootPipelineBuilder<IAggregate<CreateModel>, IAggregate<CreateModel>>
    {
        protected readonly IMapper _mapper;
        private readonly ICreateDepot _createDepot;

        public CreateStep1A(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _createDepot = service.GetRequiredService<ICreateDepot>();
        }

        protected override IAggregate<CreateModel> ExecuteRootStep(IAggregate<CreateModel> aggregate)
        {
            // Read

            // Do
            var model = aggregate.GetModel();
            var transfertModel = _mapper.Map<CreateRequestTransfertModel>(aggregate.GetModel());

            _createDepot.CreateValue(transfertModel);

            // Write

            return aggregate;
        }
    }
}