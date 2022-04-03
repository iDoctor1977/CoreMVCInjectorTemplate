using AutoMapper;
using Injector.Web.Interfaces.IMappers;

namespace Injector.Web.Converters
{
    public abstract class ABaseConverter<TIn, TOut> : IModelMapper<TIn, TOut>
    {
        private readonly IMapper _mapper;

        protected ABaseConverter(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected TOut ToExternalModelData(TIn viewModel)
        {
            var valueMap = _mapper.Map<TOut>(viewModel);

            return valueMap;
        }

        public abstract TOut ToModelData(TIn viewModel);
    }
}