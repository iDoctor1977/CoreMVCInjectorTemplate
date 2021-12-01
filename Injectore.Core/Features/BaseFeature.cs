using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature
    {
        private readonly IDataSupplier _dataSupplier;
        private readonly IOperatorSupplier _operatorSupplier;

        public BaseFeature(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
            _operatorSupplier = service.GetRequiredService<IOperatorSupplier>();
        }

        public IDataSupplier BaseFeature_DataSupplier => _dataSupplier;
        public IOperatorSupplier BaseFeature_OperatorSupplier => _operatorSupplier;
    }
}