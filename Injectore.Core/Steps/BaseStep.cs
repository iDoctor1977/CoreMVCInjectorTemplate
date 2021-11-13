using Injector.Common.ISuppliers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Steps
{
    public class BaseStep
    {
        private readonly IDataSupplier _dataSupplier;

        public BaseStep(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
        }

        public IDataSupplier BaseStep_DataSupplier => _dataSupplier;
    }
}