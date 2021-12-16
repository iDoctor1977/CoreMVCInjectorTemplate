﻿using System;
using AutoMapper;
using Injector.Common.DTOModels;
using Injector.Common.Enums;
using Injector.Common.IFeatures;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Web.Controllers
{
    public class AController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFeatureA _featureA;

        public AController(IServiceProvider service) {
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
        public ViewResult Create(VMCreateA vmCreateA)
        {
            if (ModelState.IsValid)
            {
                var dtoModelA = _mapper.Map<DTOModelA>(vmCreateA);

                var operatioResult = _featureA.CreatePost(dtoModelA);
                if (operatioResult.Status == OperationsStatus.Success)
                {
                    var vmModelA = _mapper.Map<VMCreateA>(operatioResult.Value);

                    return View(vmModelA);
                }
            }

            return View();
        }
    }
}