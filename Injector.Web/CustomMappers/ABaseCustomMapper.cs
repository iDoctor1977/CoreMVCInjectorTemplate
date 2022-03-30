using AutoMapper;
using Injector.Common.Mappers;

namespace Injector.Web.CustomMappers
{
    public abstract class ABaseCustomMapper<TIn, TOut> : ICustomMapper<TIn, TOut>
    {
        private readonly IMapper _mapper;

        protected ABaseCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected TOut ExternalMap(TIn value)
        {
            var valueMap = _mapper.Map<TOut>(value);

            return valueMap;
        }

        public abstract TOut Map(TIn value);
    }
}