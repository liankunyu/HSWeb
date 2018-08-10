using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class AshRemovalSetController : Controller
    {
        // GET: AshRemovalSet
        public ActionResult AshRemovalSet()
        {
            return View();
        }
        public ActionResult SendData()
        {           //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string daow, kongw, sud;
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            daow = opXML.QueryNodeText("num1301");
            kongw = opXML.QueryNodeText("num1302");
            sud = opXML.QueryNodeText("num1303");
            
            json = "{\"daow\":\"" + daow + "\","
                          + "\"kongw\":\"" + kongw + "\","
                          + "\"sud\":\"" + sud + "\"}";
            return Content(json);

        }

        public ActionResult postData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                XMLHelper opXML = new XMLHelper(newPath);
                opXML.ModifyNode("num1301", Request.Form["daow"]);
                opXML.ModifyNode("num1302", Request.Form["kongw"]);
                opXML.ModifyNode("num1303", Request.Form["sud"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }
    }
}