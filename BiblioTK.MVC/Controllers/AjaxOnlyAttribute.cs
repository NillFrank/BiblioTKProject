﻿using System;
using System.Web.Mvc;

namespace BiblioTK.MVC.Controllers
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
                filterContext.HttpContext.Response.Redirect("/error/404");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}