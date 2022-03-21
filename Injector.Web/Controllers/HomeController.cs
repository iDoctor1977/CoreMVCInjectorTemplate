using System;
using System.Diagnostics;
using AutoMapper;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICreateFeature _createFeature;

        public HomeController(IServiceProvider service) {
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
            CreateViewModel createGetViewModel = new CreateViewModel
            {
                Name = "iDoctor",
                Surname = "filippo.foglia@gmail.com",
                TelNumber = "+39 331 578 7943"
            };

            return View(createGetViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(CreateViewModel createViewModel)
        {
            if (ModelState.IsValid)
            {
                var createRequestTM = _mapper.Map<CreateRequestTransfertModel>(createViewModel);

                _createFeature.CreateAndAddNewValueA(createRequestTM);
            }

            return View();
        }
    }
}