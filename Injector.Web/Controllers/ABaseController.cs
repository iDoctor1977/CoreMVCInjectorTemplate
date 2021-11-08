using System.Collections.Generic;
using Injector.Common.IABases;
using Injector.Common.IStores;
using Microsoft.AspNetCore.Mvc;

namespace Injector.Web.Controllers
{
    public abstract class ABaseController : Controller, IABaseController
    {
        private IWebStore _webStore;
        private const int DefaultEntryKey = -1;
        private readonly Dictionary<int, ActionControllerName> _redirectDictionary = new Dictionary<int, ActionControllerName>();

        #region CONSTRUCTOR

        protected ABaseController()
        {
            //FillRedirectDictionary();
        }

        protected ABaseController(IWebStore webStore)
        {
            ABaseController_WebStoreInstance = webStore;
            //FillRedirectDictionary();
        }

        #endregion

        public IWebStore ABaseController_WebStoreInstance
        {
            get { return _webStore ?? (_webStore = WebStore.Instance()); }
            set { _webStore = value; }
        }

        #region EXCEPTIONS HANDLER

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

        private class ActionControllerName
        {
            public string ActionName { get; private set; }
            public string ControllerName { get; private set; }

            public ActionControllerName(string actionName, string controllerName)
            {
                ActionName = actionName;
                ControllerName = controllerName;
            }
        }

        #endregion
    }
}