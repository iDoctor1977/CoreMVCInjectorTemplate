using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature
    {
        private readonly IDataSupplier _dataSupplier;

        public BaseFeature(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
        }

        public IDataSupplier BaseFeature_DataSupplier => _dataSupplier;
    }
}