using Injector.Common.DTOModels;

namespace Injector.Common.IActionRepositories
{
    public interface IDepotA
    {
        OperationResult<DTOModelA> CreateValue(DTOModelA dtoModelA);
    }
}