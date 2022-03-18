using System;
using System.Diagnostics;
using AutoMapper;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMapper _mapper;
        private readonly ICreateFeature _createFeature;

        public HomeController(IServiceProvider service, ILogger<HomeController> logger) {
            _logger = logger;
            _mapper = service.GetRequiredService<IMapper>();
            _createFeature = service.GetRequiredService<ICreateFeature>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateGetViewModel createGetViewModel = new CreateGetViewModel
            {
                Name = "iDoctor",
                Surname = "filippo.foglia@gmail.com",
                TelNumber = "+39 331 578 7943"
            };

            return View(createGetViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(CreateGetViewModel createGetRequestVm)
        {
            if (ModelState.IsValid)
            {
                var createRequestTM = _mapper.Map<CreateRequestTransfertModel>(createGetRequestVm);

                var createResponseTM = _createFeature.CreateAndAddNewValueA(createRequestTM);

                var createResponseVM = _mapper.Map<CreateGetViewModel>(createResponseTM);

                return View(createResponseVM);
            }

            return View();
        }
    }
}