using System.Threading.Tasks;

namespace Injector.Common.Interfaces.Features
{
    public interface ICqrsQuery<TIn, TOut>
    {
        TOut Execute(TIn model);
    }
}