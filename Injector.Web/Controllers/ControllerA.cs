using System;
using Injector.Common.DTOModels;
using Injector.Web.Models;
using Injector.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Injector.Common.Enums;

namespace Injector.Frontend.Controllers
{
    public class ControllerA : BaseController
    {
        public ControllerA(IServiceProvider service) : base(service) { }

        #region HTTP OPERATIONS

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
                DTOModelA dtoModelA = BaseController_Mapper.Map<DTOModelA>(vmCreateA);

                var operatioResult = BaseController_CoreSupplier.GetFeatureA.CreatePost(dtoModelA);

                if (operatioResult.Status == OperationsStatus.Success)
                {
                    return RedirectToAction("CreateA");
                }
            }

            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Delete(Guid idA)
        {
            return RedirectToAction("Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteA vmDeleteA)
        {
            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Edit(Guid idA)
        {
            return RedirectToAction("Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditA vmEditA)
        {
            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Details(Guid idA)
        {
            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult List()
        {
            return RedirectToAction("Home");
        }

        #endregion
    }
}