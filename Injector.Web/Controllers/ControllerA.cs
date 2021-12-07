using System;
using Injector.Common.DTOModels;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Injector.Common.Enums;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Injector.Common.IFeatures;

namespace Injector.Frontend.Controllers
{
    public class ControllerA : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFeatureA _featureA;

        public ControllerA(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _featureA = service.GetRequiredService<IFeatureA>();
        }

        [HttpGet]
        public ActionResult Create()
        {
            VMCreateA vmCreateA = new VMCreateA
            {
                Name = "iDoctor",
                Surname = "filippo.foglia@gmail.com",
                TelNumber = "+39 331 578 7943"
            };

            return View(vmCreateA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMCreateA vmCreateA)
        {
            if (ModelState.IsValid)
            {
                var dtoModelA = _mapper.Map<DTOModelA>(vmCreateA);

                var operatioResult = _featureA.CreatePost(dtoModelA);
                if (operatioResult.Value)
                {
                    return RedirectToAction("CreateA");
                }
            }

            return RedirectToAction("Home");
        }
    }
}