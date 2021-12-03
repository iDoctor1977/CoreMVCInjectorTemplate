using System;
using AutoMapper;
using Injector.Common.IFeatures;
using Injector.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Injector.Frontend.Controllers
{
    public class ControllerB : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFeatureB _featureB;

        public ControllerB(IServiceProvider service) {
            _mapper = service.GetRequiredService<IMapper>();
            _featureB = service.GetRequiredService<IFeatureB>();
        }

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
                return RedirectToAction("Home");
            }

            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Delete(Guid idB)
        {
            return RedirectToAction("Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteB vmDeleteB)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home");
            }

            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Edit(Guid idB)
        {
            return RedirectToAction("Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditB vmEditB)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home");
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid idB)
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