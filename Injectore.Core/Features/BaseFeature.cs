using Injector.Common.IBases;
using Injector.Common.IStores;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Core.Features
{
    public class BaseFeature : IBaseFeature
    {
        public BaseFeature() { }

        public BaseFeature(IServiceProvider service)
        {
            service.GetRequiredService<ICoreStore>();
        }

        public ICoreStore BaseFeature_CoreStoreInstance => BaseFeature_CoreStoreInstance;
    }
}