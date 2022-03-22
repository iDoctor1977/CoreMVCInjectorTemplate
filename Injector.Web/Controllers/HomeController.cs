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
        private readonly IReadFeature _readFeature;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(CreateViewModel createViewModel)
        {
            var createRequestTM = _mapper.Map<CreateRequestTransfertModel>(createViewModel);

            if (ModelState.IsValid)
            {
                _createFeature.Execute(createRequestTM);
            }

            createViewModel = _mapper.Map<CreateViewModel>(createRequestTM);

            return View(createViewModel);
        }

        [HttpGet]
        public ActionResult Read(ReadViewModel readViewModel)
        {
            if (ModelState.IsValid)
            {
                var readRequestTM = _mapper.Map<ReadRequestTransfertModel>(readViewModel);

                _readFeature.Execute(readRequestTM);
            }

            return View(readViewModel);
        }
    }
}