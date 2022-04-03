using System;
using System.Diagnostics;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Models;
using Injector.Web.Interfaces.IMappers;
using Injector.Web.Interfaces.IPresenters;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IModelMapper<CreateViewModel, CreateModel> _createModelMapper;
        private readonly IModelMapper<ReadViewModel, ReadModel> _readModelMapper;

        private readonly IPresenter<ReadModel, ReadViewModel> _readPresenter;

        private readonly ICreateFeature _createFeature;
        private readonly IReadFeature _readFeature;

        public HomeController(IServiceProvider service) {
            _createModelMapper = service.GetRequiredService<IModelMapper<CreateViewModel, CreateModel>>();
            _readModelMapper = service.GetRequiredService<IModelMapper<ReadViewModel, ReadModel>>();

            _readPresenter = service.GetRequiredService<IPresenter<ReadModel, ReadViewModel>>();

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
        public ViewResult Create(CreateViewModel createViewModel)
        {
            var createModel = _createModelMapper.ToModelData(createViewModel);

            if (ModelState.IsValid)
            {
                _createFeature.Execute(createModel);
            }

            return View(createViewModel);
        }

        [HttpGet]
        public ViewResult Read(ReadViewModel readViewModel)
        {
            var model = _readModelMapper.ToModelData(readViewModel);
            
            if (ModelState.IsValid)
            {
                model = _readFeature.Execute(model);
            }

            readViewModel = _readPresenter.ToViewData(model);

            return View(readViewModel);
        }
    }
}