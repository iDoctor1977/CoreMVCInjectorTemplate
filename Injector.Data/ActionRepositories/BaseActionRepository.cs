using Injector.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Common.ActionRepositories
{
    public class BaseActionRepository
    {
        private readonly DataStore _dataStore;

        public BaseActionRepository(IServiceProvider service) {
            _dataStore = service.GetRequiredService<DataStore>();
        }

        public DataStore BaseActionRepository_DataStore => _dataStore;
    }
}
