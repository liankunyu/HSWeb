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
    public class ModSetController : Controller
    {
        // GET: ModSet
        public ActionResult ModSet()
        {
            return View();
        }
        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] modSet = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            modSet[1] = opXML.QueryNodeText("num3401");
            modSet[2] = opXML.QueryNodeText("num3402");
            modSet[3] = opXML.QueryNodeText("num3403");
            modSet[4] = opXML.QueryNodeText("num3404");
            modSet[5] = opXML.QueryNodeText("num3405");
            modSet[6] = opXML.QueryNodeText("num3406");
            modSet[7] = opXML.QueryNodeText("num3407");
            modSet[8] = opXML.QueryNodeText("num3408");
            modSet[9] = opXML.QueryNodeText("num3409");
            modSet[10] = opXML.QueryNodeText("num3410");
            modSet[11] = opXML.QueryNodeText("num3411");
            modSet[12] = opXML.QueryNodeText("num3412");
            modSet[13] = opXML.QueryNodeText("num3413");
            modSet[14] = opXML.QueryNodeText("num3414");
            modSet[15] = opXML.QueryNodeText("num3415");
            modSet[16] = opXML.QueryNodeText("num3416");
            modSet[17] = opXML.QueryNodeText("num3417");
            modSet[18] = opXML.QueryNodeText("num3418");
            modSet[19] = opXML.QueryNodeText("num3419");
            modSet[20] = opXML.QueryNodeText("num3420");
            modSet[21] = opXML.QueryNodeText("num3421");
            modSet[22] = opXML.QueryNodeText("num3422");

            json = "{\"mod1\":\"" + modSet[1] + "\","
                          + "\"mod2\":\"" + modSet[2] + "\","
                          + "\"mod3\":\"" + modSet[3] + "\","
                          + "\"mod4\":\"" + modSet[4] + "\","
                          + "\"mod5\":\"" + modSet[5] + "\","
                          + "\"mod6\":\"" + modSet[6] + "\","
                          + "\"mod7\":\"" + modSet[7] + "\","
                          + "\"mod8\":\"" + modSet[8] + "\","
                          + "\"mod9\":\"" + modSet[9] + "\","
                          + "\"mod10\":\"" + modSet[10] + "\","
                          + "\"mod11\":\"" + modSet[11] + "\","
                          + "\"mod12\":\"" + modSet[12] + "\","
                          + "\"mod13\":\"" + modSet[13] + "\","
                          + "\"mod14\":\"" + modSet[14] + "\","
                          + "\"mod15\":\"" + modSet[15] + "\","
                          + "\"mod16\":\"" + modSet[16] + "\","
                          + "\"mod17\":\"" + modSet[17] + "\","
                          + "\"mod18\":\"" + modSet[18] + "\","
                          + "\"mod19\":\"" + modSet[19] + "\","
                          + "\"mod20\":\"" + modSet[20] + "\","
                          + "\"mod21\":\"" + modSet[21] + "\","
                          + "\"mod22\":\"" + modSet[22] + "\"}";
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
                opXML.ModifyNode("num3401", Request.Form["mod1"]);
                opXML.ModifyNode("num3402", Request.Form["mod2"]);
                opXML.ModifyNode("num3403", Request.Form["mod3"]);
                opXML.ModifyNode("num3404", Request.Form["mod4"]);
                opXML.ModifyNode("num3405", Request.Form["mod5"]);
                opXML.ModifyNode("num3406", Request.Form["mod6"]);
                opXML.ModifyNode("num3407", Request.Form["mod7"]);
                opXML.ModifyNode("num3408", Request.Form["mod8"]);
                opXML.ModifyNode("num3409", Request.Form["mod9"]);
                opXML.ModifyNode("num3410", Request.Form["mod10"]);
                opXML.ModifyNode("num3411", Request.Form["mod11"]);
                opXML.ModifyNode("num3412", Request.Form["mod12"]);
                opXML.ModifyNode("num3413", Request.Form["mod13"]);
                opXML.ModifyNode("num3414", Request.Form["mod14"]);
                opXML.ModifyNode("num3415", Request.Form["mod15"]);
                opXML.ModifyNode("num3416", Request.Form["mod16"]);
                opXML.ModifyNode("num3417", Request.Form["mod17"]);
                opXML.ModifyNode("num3418", Request.Form["mod18"]);
                opXML.ModifyNode("num3419", Request.Form["mod19"]);
                opXML.ModifyNode("num3420", Request.Form["mod20"]);

                opXML.ModifyNode("num3422", Request.Form["mod22"]);
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