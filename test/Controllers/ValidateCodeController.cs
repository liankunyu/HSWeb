using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDaMing.Util;
namespace TMC_SZ.Controllers
{
    public class ValidateCodeController : Controller
    {
        // GET: /ValidateCode/

        public ActionResult Validatecode()
        {
            string code = ValidateCode.CreateRandomCode(4);
            string check_code = code;
            HttpCookie cookie = Request.Cookies["CheckCode"];
            if (cookie != null)
            {
                cookie.Values.Clear();
                cookie.Values.Add("checkcode_value", check_code);
                Response.AppendCookie(cookie);
            }
            else
            {
                cookie = new HttpCookie("CheckCode");
                cookie.Values.Add("checkcode_value", check_code);
                Response.AppendCookie(cookie);
            }
            byte[] bytes = ValidateCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

    }
}
