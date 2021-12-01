using System;
using System.Collections.Generic;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IActionRepositories;
using Injector.Data.ADOModels;

namespace Injector.Common.ActionRepositories
{
    public class ActionRepositoryA : BaseActionRepository, IActionRepositoryA
    {
        public ActionRepositoryA(IServiceProvider service) : base(service) { }

        public OperationResult<bool> CreateValue(DTOModelA dtoModelA)
        {
            EntityA entityA = BaseActionRepository_Mapper.Map<EntityA>(dtoModelA);

            if (GetRepositoryA.CreateEntity(entityA) > 0)
            {
                return new OperationResult<bool> {
                    Value = true,
                    Message = OperationsStatus.Success.ToString(),
                    Status = OperationsStatus.Success
                };
            }

            return new OperationResult<bool> { 
                Value = false,
                Message = OperationsStatus.Error.ToString(),
                Status = OperationsStatus.Error
            };
        }

        public OperationResult<bool> DeleteValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public OperationResult<IEnumerable<DTOModelA>> ReadValues()
        {
            throw new NotImplementedException();
        }

        public OperationResult<DTOModelA> ReadValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }

        public OperationResult<bool> UpdateValue(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}
