using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature
    {
        private readonly IDataSupplier _dataSupplier;
        private readonly IOperationsSupplier _operationsSupplier;
        private readonly IFunctionSupplier _functionSupplier;

        public BaseFeature(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
            _operationsSupplier = service.GetRequiredService<IOperationsSupplier>();
            _functionSupplier = service.GetRequiredService<IFunctionSupplier>();
        }

        public IDataSupplier BaseFeature_DataSupplier => _dataSupplier;
        public IOperationsSupplier BaseFeature_OperationsSupplier => _operationsSupplier;
        public IFunctionSupplier BaseFeature_FunctionsSupplier => _functionSupplier;
    }
}