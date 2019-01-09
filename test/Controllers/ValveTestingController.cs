using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Controllers.Filter;

namespace test.Controllers
{
    [LoginFilter]
    public class ValveTestingController : Controller
    {
        // GET: ValveTesting
        public ActionResult ValveTesting()
        {
            ViewBag.deviceID = test.common.deviceID;
            return View();
        }
        public ActionResult ValveTesting1()
        {
            return View();
        }
        public ActionResult SendData()
        {       
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] famen = new string[10];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            famen[1] = opXML.QueryNodeText("num0501");
            famen[2] = opXML.QueryNodeText("num0502");
            famen[3] = opXML.QueryNodeText("num0503");
            famen[4] = opXML.QueryNodeText("num0504");
            famen[5] = opXML.QueryNodeText("num0505");
            famen[6] = opXML.QueryNodeText("num0506");
            famen[7] = opXML.QueryNodeText("num0507");

           json = "{\"famen1\":\"" + famen[1] + "\","
                          + "\"famen2\":\"" + famen[2] + "\","
                          + "\"famen3\":\"" + famen[3] + "\","
                          + "\"famen4\":\"" + famen[4] + "\","
                          + "\"famen5\":\"" + famen[5] + "\","
                          + "\"famen6\":\"" + famen[6] + "\","
                          + "\"famen7\":\"" + famen[7] + "\"}";
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
                opXML.ModifyNode("num0501", Request.Form["famen1"]);
                opXML.ModifyNode("num0502", Request.Form["famen2"]);
                opXML.ModifyNode("num0503", Request.Form["famen3"]);
                opXML.ModifyNode("num0504", Request.Form["famen4"]);
                opXML.ModifyNode("num0505", Request.Form["famen5"]);
                opXML.ModifyNode("num0506", Request.Form["famen6"]);
                opXML.ModifyNode("num0507", Request.Form["famen7"]);
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