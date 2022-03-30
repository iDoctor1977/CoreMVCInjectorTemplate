using System;
using System.Diagnostics;
using Injector.Common.Interfaces.IFeatures;
using Injector.Common.Interfaces.IPresenters;
using Injector.Common.Mappers;
using Injector.Common.Models;
using Injector.Web.CustomMappers;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomMapper<CreateViewModel, CreateModel> _createModelMapper;
        private readonly ReadModelMapper _readModelMapper;

        private readonly IPresenter<ReadModel, ReadViewModel> _readPresenter;

        private readonly ICreateFeature _createFeature;
        private readonly IReadFeature _readFeature;

        public HomeController(IServiceProvider service) {
            _createModelMapper = service.GetRequiredService<DefaultMapper<CreateViewModel, CreateModel>>();
            _readModelMapper = service.GetRequiredService<ReadModelMapper>();

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
            var createModel = _createModelMapper.Map(createViewModel);

            if (ModelState.IsValid)
            {
                _createFeature.Execute(createModel);
            }

            return View(createViewModel);
        }

        [HttpGet]
        public ViewResult Read(ReadViewModel readViewModel)
        {
            var model = _readModelMapper.Map(readViewModel);
            
            if (ModelState.IsValid)
            {
                model = _readFeature.Execute(model);
            }

            readViewModel = _readPresenter.ToViewData(model);

            return View(readViewModel);
        }
    }
}