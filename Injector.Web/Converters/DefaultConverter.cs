using AutoMapper;

namespace Injector.Web.Converters
{
    public sealed class DefaultConverter<TIn, TOut> : ABaseConverter<TIn, TOut>
    {
        public DefaultConverter(IMapper mapper) : base(mapper) { }

        public override TOut ToModelData(TIn viewModel)
        {
            var model = ToExternalModelData(viewModel);

            return model;
        }
    }
}