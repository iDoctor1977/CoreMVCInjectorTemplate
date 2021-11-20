using AutoMapper;
using Injector.Common.ISuppliers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICoreSupplier _coreSupplier;

        public BaseController(IServiceProvider service)
        {
            _mapper = service.GetRequiredService<IMapper>();
            _coreSupplier = service.GetRequiredService<ICoreSupplier>();
        }

        public IMapper BaseController_Mapper => _mapper;

        public ICoreSupplier BaseController_CoreSupplier => _coreSupplier;
    }
}