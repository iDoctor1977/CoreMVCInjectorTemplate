using System;
using System.Diagnostics;
using Injector.Common.Interfaces.IConsolidators;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConsolidators<CreateViewModel, CreateModel> _createDefaultReceiver;
        private readonly IConsolidators<ReadViewModel, ReadModel> _readCustomReceiver;

        private readonly IConsolidators<ReadModel, ReadViewModel> _readCustomPresenter;

        private readonly ICreateFeature _createFeature;
        private readonly IReadFeature _readFeature;

        public HomeController(IServiceProvider service) {
            _createDefaultReceiver = service.GetRequiredService<IConsolidators<CreateViewModel, CreateModel>>();
            _readCustomReceiver = service.GetRequiredService<IConsolidators<ReadViewModel, ReadModel>>();

            _readCustomPresenter = service.GetRequiredService<IConsolidators<ReadModel, ReadViewModel>>();

            _createFeature = service.GetRequiredService<ICreateFeature>();
            _readFeature = service.GetRequiredService<IReadFeature>();
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
        public IActionResult Create(CreateViewModel viewModel)
        {
            var model = _createDefaultReceiver.ToData(viewModel);

            if (ModelState.IsValid)
            {
                _createFeature.Execute(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Read(ReadViewModel viewModel)
        {
            var model = _readCustomReceiver.ToData(viewModel);
            
            if (ModelState.IsValid)
            {
                model = _readFeature.Execute(model);
            }

            viewModel = _readCustomPresenter.ToData(model);

            return View(viewModel);
        }
    }
}