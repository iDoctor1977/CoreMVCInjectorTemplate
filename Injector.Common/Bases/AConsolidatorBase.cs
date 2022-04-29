using System;
using Injector.Common.Interfaces.IConsolidators;
using Injector.Common.Interfaces.ICustomMappers;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Common.Bases
{
    public abstract class AConsolidatorBase<TIn, TOut> : IConsolidators<TIn, TOut>
    {
        private readonly ICustomMapper _customMapper;

        protected AConsolidatorBase(IServiceProvider service)
        {
            _customMapper = service.GetRequiredService<ICustomMapper>();
        }

        protected TOut ToExternalData(TIn model)
        {
            var valueMap = _customMapper.Map<TIn, TOut>(model);

            return valueMap;
        }

        public abstract TOut ToData(TIn model);
    }
}