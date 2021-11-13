using System;
using Injector.Common.DTOModels;
using Injector.Web.Controllers;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Injector.Frontend.Controllers
{
    public class ControllerB : BaseController
    {
        public ControllerB(IServiceProvider service) : base(service) { }

        #region HTTP OPERATIONS

        [HttpGet]
        public ActionResult Create()
        {
            VMCreateB vmCreateB = new VMCreateB();
            vmCreateB.Username = "iDoctor";
            vmCreateB.Email = "filippo.foglia@gmail.com";
            vmCreateB.Birth = "18/07/1977";

            return View(vmCreateB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMCreateB vmCreateB)
        {
            if (ModelState.IsValid)
            {
                // mapping visual model to DTO
                DTOModelB dtoModelB = new DTOModelB();

                BaseController_CoreSupplier.GetFeatureB.CreatePost(dtoModelB);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(Guid idB)
        {
            VMDeleteB vmDeleteB = new VMDeleteB();

            // mapping visual model to DTO
            DTOModelB dtoModelB = new DTOModelB();

            BaseController_CoreSupplier.GetFeatureB.DeleteGet(dtoModelB);

            return View(vmDeleteB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteB vmDeleteB)
        {
            if (ModelState.IsValid)
            {
                // mapping visual model to DTO
                DTOModelB dtoModelB = new DTOModelB();

                BaseController_CoreSupplier.GetFeatureB.DeletePost(dtoModelB);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(Guid idB)
        {
            VMEditB vmEditB = new VMEditB();

            // mapping visual model to DTO
            DTOModelB dtoModelB = new DTOModelB();

            dtoModelB = BaseController_CoreSupplier.GetFeatureB.EditGet(dtoModelB);

            return View(vmEditB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditB vmEditB)
        {
            if (ModelState.IsValid)
            {
                // mapping visual model to DTO
                DTOModelB dtoModelB = new DTOModelB();

                BaseController_CoreSupplier.GetFeatureB.EditPost(dtoModelB);
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid idB)
        {
            VMDetailsB vmDetailsB = new VMDetailsB();

            // mapping visual model to DTO
            DTOModelB dtoModelB = new DTOModelB();

            dtoModelB = BaseController_CoreSupplier.GetFeatureB.DetailsGet(dtoModelB);

            return View(vmDetailsB);
        }

        [HttpGet]
        public ActionResult List()
        {
            VMListB vmListB = new VMListB();

            // mapping visual model to DTO
            DTOModelB dtoModelB = new DTOModelB();

            dtoModelB = BaseController_CoreSupplier.GetFeatureB.ListGet(dtoModelB);

            return View(vmListB);
        }

        #endregion
    }
}