using AutoMapper;
using Injector.Web.Interfaces.IConverters;

namespace Injector.Web.Converters
{
    public abstract class ABaseConverter<TIn, TOut> : IConverter<TIn, TOut>
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