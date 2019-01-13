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
            //ROV是Return on Value返回值
            bool[] ROV = new bool[10];
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
                ROV[1] = opXML.ModifyNode("num1301", Request.Form["daow"]);
                ROV[2] = opXML.ModifyNode("num1302", Request.Form["kongw"]);
                ROV[3] = opXML.ModifyNode("num1303", Request.Form["sud"]);
                ROV[4] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 5; i++)
                {
                    if (ROV[i] == false)
                    {
                        return Content("Error");
                    }
                }
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }
    }
}