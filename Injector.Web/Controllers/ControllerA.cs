﻿using System;
using Injector.Common.DTOModels;
using Injector.Web.Models;
using Injector.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Injector.Frontend.Controllers
{
    public class ControllerA : BaseController
    {
        public ControllerA(IServiceProvider service) : base(service) { }

        #region HTTP OPERATIONS

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMCreateA vmCreateA)
        {
            if (ModelState.IsValid)
            {
                // mapping visual model to DTO
                DTOModelA dtoModelA = new DTOModelA();
                dtoModelA.Name = vmCreateA.Name;

                // ex. with FEATURE
                BaseController_CoreSupplier.GetFeatureA.CreatePost(dtoModelA);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(Guid idA)
        {
            // mapping visual model to DTO
            VMDeleteA vmDeleteA = new VMDeleteA();
            DTOModelA dtoModelA = new DTOModelA();

            //vmDeleteA = ABaseController_WebStoreInstance.WebStore_CoreSupplierInstance.GetFeatureA.DeleteGet(vmDeleteA) as VMDeleteA;

            return View(vmDeleteA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteA vmDeleteA)
        {
            if (ModelState.IsValid)
            {
                // mapping visual model to DTO
                DTOModelA dtoModelA = new DTOModelA();

                BaseController_CoreSupplier.GetFeatureA.DeletePost(dtoModelA);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(Guid idA)
        {
            VMEditA vmEditA = new VMEditA();

            // mapping visual model to DTO
            DTOModelA dtoModelA = new DTOModelA();

            // ex. with FEATURE
            //vmEditA = ABaseController_WebStoreInstance.WebStore_CoreSupplierInstance.GetFeatureA.EditGet(vmEditA) as VMEditA;

            return View(vmEditA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditA vmEditA)
        {
            if (ModelState.IsValid)
            {
                // ex. with FEATURE
                //ABaseController_WebStoreInstance.WebStore_CoreSupplierInstance.GetFeatureA.EditPost(vmEditA);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid idA)
        {
            VMDetailsA vmDetailsA = new VMDetailsA();

            // mapping visual model to DTO
            DTOModelA dtoModelA = new DTOModelA();

            // ex. with FEATURE
            //vmDetailsA = ABaseController_WebStoreInstance.WebStore_CoreSupplierInstance.GetFeatureA.DetailsGet(vmDetailsA) as VMDetailsA;

            return View(vmDetailsA);
        }

        [HttpGet]
        public ActionResult List()
        {
            VMListA vmListA = new VMListA();

            // ex. with FEATURE
            //vmListA = ABaseController_WebStoreInstance.WebStore_CoreSupplierInstance.GetFeatureA.ListGet(vmListA) as VMListA;

            return View(vmListA);
        }

        #endregion
    }
}