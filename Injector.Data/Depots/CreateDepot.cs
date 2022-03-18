using System;
using AutoMapper;
using Injector.Common;
using Injector.Common.Enums;
using Injector.Common.Interfaces.IActionRepositories;
using Injector.Common.Models;
using Injector.Data.Entities;
using Injector.Data.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Data.Depots
{
    public class CreateDepot : ICreateDepot
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryA _repositoryA;

        public CreateDepot(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _repositoryA = service.GetRequiredService<IRepositoryA>();
        }

        public CreateResponseTransfertModel CreateValue(CreateRequestTransfertModel createRequestTM)
        {
            AEntity aEntity = _mapper.Map<AEntity>(createRequestTM);

            if (_repositoryA.CreateEntity(aEntity) > 0)
            {
                createRequestTM = _mapper.Map<CreateRequestTransfertModel>(aEntity);

                return new OperationResult<CreateRequestTransfertModel> {
                    Value = createRequestTM,
                    Message = OperationsStatus.Success.ToString(),
                    Status = OperationsStatus.Success
                };
            }

            return new OperationResult<CreateRequestTransfertModel> {
                Value = null,
                Message = OperationsStatus.Error.ToString(),
                Status = OperationsStatus.Error
            };
        }
    }
}
