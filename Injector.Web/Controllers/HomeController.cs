using System;
using System.Diagnostics;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Web.Interfaces.IConverters;
using Injector.Web.Interfaces.IPresenters;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConverter<CreateViewModel, CreateModel> _createDefaultConverter;
        private readonly IConverter<ReadViewModel, ReadModel> _readCustomConverter;

        private readonly IPresenter<ReadModel, ReadViewModel> _readCustomPresenter;

        private readonly ICreateFeature _createFeature;
        private readonly IReadFeature _readFeature;

        public HomeController(IServiceProvider service) {
            _createDefaultConverter = service.GetRequiredService<IConverter<CreateViewModel, CreateModel>>();
            _readCustomConverter = service.GetRequiredService<IConverter<ReadViewModel, ReadModel>>();

            _readCustomPresenter = service.GetRequiredService<IPresenter<ReadModel, ReadViewModel>>();

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
            var model = _createDefaultConverter.ToModelData(viewModel);

            if (ModelState.IsValid)
            {
                _createFeature.Execute(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Read(ReadViewModel viewModel)
        {
            var model = _readCustomConverter.ToModelData(viewModel);
            
            if (ModelState.IsValid)
            {
                model = _readFeature.Execute(model);
            }

            viewModel = _readCustomPresenter.ToViewData(model);

            return View(viewModel);
        }
    }
}