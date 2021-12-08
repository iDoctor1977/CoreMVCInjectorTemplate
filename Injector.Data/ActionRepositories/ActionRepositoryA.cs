using System;
using System.Collections.Generic;
using AutoMapper;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IActionRepositories;
using Injector.Data.ADOModels;
using Injector.Data.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryA : IActionRepositoryA
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryA _repositoryA;

        public ActionRepositoryA(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _repositoryA = service.GetRequiredService<IRepositoryA>();
        }

        public OperationResult<DTOModelA> CreateValue(DTOModelA dtoModelA)
        {
            EntityA entityA = _mapper.Map<EntityA>(dtoModelA);

            if (_repositoryA.CreateEntity(entityA) > 0)
            {
                dtoModelA = _mapper.Map<DTOModelA>(entityA);

                return new OperationResult<DTOModelA> {
                    Value = dtoModelA,
                    Message = OperationsStatus.Success.ToString(),
                    Status = OperationsStatus.Success
                };
            }

            return new OperationResult<DTOModelA> {
                Value = null,
                Message = OperationsStatus.Error.ToString(),
                Status = OperationsStatus.Error
            };
        }

        public OperationResult<DTOModelA> DeleteValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public OperationResult<DTOModelA> ReadValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public OperationResult<DTOModelA> UpdateValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public OperationResult<IEnumerable<DTOModelA>> ReadValues()
        {
            throw new NotImplementedException();
        }
    }
}
