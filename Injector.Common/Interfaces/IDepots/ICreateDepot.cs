using Injector.Common.Interfaces.ICqrs;
using Injector.Common.Models;

namespace Injector.Common.Interfaces.IDepots
{
    public interface ICreateDepot : ICqrsCommand<CreateModel> { }
}