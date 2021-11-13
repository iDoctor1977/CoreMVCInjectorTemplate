using Injector.Common.ISuppliers;
using Injector.Core.Steps.ASteps;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature
    {
        private readonly IDataSupplier _dataSupplier;

        private readonly CreateStep1A _createStep1A;
        private readonly CreateStep2A _createStep2A;
        private readonly CreateStep3A _createStep3A;

        public BaseFeature(IServiceProvider service)
        {
            _dataSupplier = service.GetRequiredService<IDataSupplier>();
            _createStep1A = service.GetRequiredService<CreateStep1A>();
            _createStep2A = service.GetRequiredService<CreateStep2A>();
            _createStep3A = service.GetRequiredService<CreateStep3A>();
        }

        public IDataSupplier BaseFeature_DataSupplier => _dataSupplier;

        public CreateStep1A BaseFeature_CreateStep1A => _createStep1A;
        public CreateStep2A BaseFeature_CreateStep2A => _createStep2A;
        public CreateStep3A BaseFeature_CreateStep3A => _createStep3A;
    }
}