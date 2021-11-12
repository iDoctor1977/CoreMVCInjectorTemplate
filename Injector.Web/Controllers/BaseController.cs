using Injector.Common.ISuppliers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Injector.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICoreSupplier _coreSupplier;
        private const int DefaultEntryKey = -1;

        //private readonly Dictionary<int, ActionControllerName> _redirectDictionary = new Dictionary<int, ActionControllerName>();

        public BaseController(IServiceProvider service)
        {
            _coreSupplier = service.GetRequiredService<ICoreSupplier>();
            //FillRedirectDictionary();
        }

        public ICoreSupplier BaseController_CoreSupplier => _coreSupplier;

        //#region EXCEPTIONS HANDLER

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    // Redirect user to error page
        //    filterContext.ExceptionHandled = true;
        //    // redirect to error view
        //    filterContext.Result = GetRedirect(filterContext.Exception);

        //    base.OnException(filterContext);
        //}

        //private void FillRedirectDictionary()
        //{
        //    _redirectDictionary.Add(DefaultEntryKey, new ActionControllerName("Index", "Error"));
        //    _redirectDictionary.Add((int)HttpStatusCode.NotFound, new ActionControllerName("PageNotFound", "Error"));
        //    _redirectDictionary.Add((int)HttpStatusCode.InternalServerError, new ActionControllerName("ServerError", "Error"));
        //    // more to add
        //}

        //private RedirectToRouteResult GetRedirect(Exception exception)
        //{
        //    var errorCode = DefaultEntryKey;
        //    var httpException = exception as HttpListenerException;

        //    if (httpException != null)
        //    {
        //        errorCode = httpException.GetHttpCode();
        //        if (!_redirectDictionary.ContainsKey(errorCode))
        //            errorCode = DefaultEntryKey;
        //    }

        //    var acn = _redirectDictionary[errorCode];
        //    return RedirectToAction(acn.ActionName, acn.ControllerName);
        //}

        //private class ActionControllerName
        //{
        //    public string ActionName { get; private set; }
        //    public string ControllerName { get; private set; }

        //    public ActionControllerName(string actionName, string controllerName)
        //    {
        //        ActionName = actionName;
        //        ControllerName = controllerName;
        //    }
        //}

        //#endregion
    }
}