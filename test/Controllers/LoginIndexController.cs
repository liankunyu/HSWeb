using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DA;
using MvcDaMing.Util;
using System.Data;


using TMC_SZ;
namespace TMC_SZ.Controllers
{
    public class LoginIndexController : Controller
    {

        public ActionResult LoginIndex()
        {
            ViewBag.CnName = "色选机远程监控与管理系统";
            ViewBag.EnName = "Hons";
            return View();
        }


        [HttpPost]

        public ActionResult Verify()
        {

            string txtuser = Request.Form["txtuser"];
            string txtpass = Request.Form["txtpass"];
            DataTable dt = new DataTable();
            string hs_sql = "select * from UserInfo where userName='" + txtuser + "' and passWord='" + txtpass + "'";
            dt = DbHelperSQL.OpenTable(hs_sql);
            if (dt.Rows.Count > 0)
            {
                System.Web.HttpContext.Current.Session["already_user"] = txtuser;
                System.Web.HttpContext.Current.Session.Timeout = 300000;   //对有后台每隔几秒就有请求的页面无效

               string json = "{\"userName\":\"" + dt.Rows[0][0].ToString().Trim() + "\","

                                  + "\"password\":\"" + dt.Rows[0][1].ToString().Trim() + "\","
                                  + "\"regTime\":\"" + dt.Rows[0][3].ToString().Trim() + "\","
                                  + "\"Jurisdiction\":\"" + dt.Rows[0][4].ToString().Trim() + "\"}";
               
                return Content(json);
            }
            else
            {
                return Content("Nodata");
            }


        }
        public ActionResult VerifyDevice()
        {
            string deviceID, fileName, hs_sql, path, newPath;
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            DataTable dt1 = new DataTable();
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            dt1 = DbHelperSQL.OpenTable(hs_sql);
            if (dt1.Rows.Count > 0)
            {
                //获得文件路径
                hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
                path = DbHelperSQL.ExecuteQuery(hs_sql);
                newPath = System.IO.Path.Combine(path, fileName);
                newPath += ".xml";
                path = System.IO.Path.Combine(path, "lasttime.xml");
                try
                {
                    //c#实现把一个文件从一个文件夹复制到另外一个文件夹并改名
                    System.IO.File.Copy(path, newPath, true);//允许覆盖目的地的同名文件
                    return Content("Success");
                }
                catch
                {
                    return Content("Nodata");
                }
            }
            else
            {
                return Content("Nofound");
            }
        }
    }

}
