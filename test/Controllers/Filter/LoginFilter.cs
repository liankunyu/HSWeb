using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MvcDaMing.Util;
//using DA;
namespace TMC_SZ.Controllers.Filter
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if ((HttpContext.Current.Session["already_user"] != null) && (HttpContext.Current.Session["already_user"].ToString() != "") && (HttpContext.Current.Session["already_user"].ToString() == HttpContext.Current.Request.Cookies["AdminName"].Value))
            {
                return;
            }
            else
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["autologin"];

                if (cookie == null)
                {

                    filterContext.Result = new RedirectResult("/Login/Login");
                    return;
                }
                else
                {
                    cookie.Value = "false";
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    filterContext.Result = new RedirectResult("/Login/Login");
                    return;
                }
            }


        }
    }
}