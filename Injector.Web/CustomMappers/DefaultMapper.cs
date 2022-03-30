using AutoMapper;

namespace Injector.Web.CustomMappers
{
    public sealed class DefaultMapper<TIn, TOut> : ABaseCustomMapper<TIn, TOut>
    {
        public DefaultMapper(IMapper mapper) : base(mapper)
        {
        }

        public override TOut Map(TIn value)
        {
            var map = ExternalMap(value);

            return map;
        }
    }
}