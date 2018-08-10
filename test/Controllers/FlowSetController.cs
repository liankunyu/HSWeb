using DA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class FlowSetController : Controller
    {
        // GET: FlowSet
        public ActionResult FlowSet()
        {
            return View();
        }
        public ActionResult FlowSet1()
        {

            return View();

        }


        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] flowSet = new string[40];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            flowSet[1] = opXML.QueryNodeText("num1001");
            flowSet[2] = opXML.QueryNodeText("num1002");
            flowSet[3] = opXML.QueryNodeText("num1003");
            flowSet[4] = opXML.QueryNodeText("num1004");
            flowSet[5] = opXML.QueryNodeText("num1005");
            flowSet[6] = opXML.QueryNodeText("num1006");
            flowSet[7] = opXML.QueryNodeText("num1007");
            flowSet[8] = opXML.QueryNodeText("num1008");
            flowSet[9] = opXML.QueryNodeText("num1009");
            flowSet[10] = opXML.QueryNodeText("num1010");
            flowSet[11] = opXML.QueryNodeText("num1011");
            flowSet[12] = opXML.QueryNodeText("num1012");
            flowSet[13] = opXML.QueryNodeText("num1013");

            flowSet[21] = opXML.QueryNodeText("num3501");
            flowSet[22] = opXML.QueryNodeText("num3502");
            flowSet[23] = opXML.QueryNodeText("num3503");
            flowSet[24] = opXML.QueryNodeText("num3504");
            flowSet[25] = opXML.QueryNodeText("num3505");
            flowSet[26] = opXML.QueryNodeText("num3506");
            flowSet[27] = opXML.QueryNodeText("num3507");
            flowSet[28] = opXML.QueryNodeText("num3508");
            flowSet[29] = opXML.QueryNodeText("num3509");
            flowSet[30] = opXML.QueryNodeText("num3510");
            json = "{\"firsttd\":\"" + flowSet[1] + "\","
                          + "\"twotd\":\"" + flowSet[2] + "\","
                          + "\"threetd\":\"" + flowSet[3] + "\","
                          + "\"fourtd\":\"" + flowSet[4] + "\","
                          + "\"fivetd\":\"" + flowSet[5] + "\","
                          + "\"sixtd\":\"" + flowSet[6] + "\","
                          + "\"seventd\":\"" + flowSet[7] + "\","
                          + "\"eighttd\":\"" + flowSet[8] + "\","
                          + "\"ninetd\":\"" + flowSet[9] + "\","
                          + "\"tentd\":\"" + flowSet[10] + "\","
                          + "\"ycll\":\"" + flowSet[11] + "\","
                          + "\"ecll\":\"" + flowSet[12] + "\","
                          + "\"scll\":\"" + flowSet[13] + "\","
                          + "\"yitongdao\":\"" + flowSet[21] + "\","
                          + "\"ertongdao\":\"" + flowSet[22] + "\","
                          + "\"santongdao\":\"" + flowSet[23] + "\","
                          + "\"sitongdao\":\"" + flowSet[24] + "\","
                          + "\"wutongdao\":\"" + flowSet[25] + "\","
                          + "\"liutongdao\":\"" + flowSet[26] + "\","
                          + "\"qitongdao\":\"" + flowSet[27] + "\","
                          + "\"batongdao\":\"" + flowSet[28] + "\","
                          + "\"jiutongdao\":\"" + flowSet[29] + "\","
                          + "\"shitongdao\":\"" + flowSet[30] + "\"}";

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
                opXML.ModifyNode("num1001", Request.Form["firsttd"]);
                opXML.ModifyNode("num1002", Request.Form["twotd"]);
                opXML.ModifyNode("num1003", Request.Form["threetd"]);
                opXML.ModifyNode("num1004", Request.Form["fourtd"]);
                opXML.ModifyNode("num1005", Request.Form["fivetd"]);
                opXML.ModifyNode("num1006", Request.Form["sixtd"]);
                opXML.ModifyNode("num1007", Request.Form["seventd"]);
                opXML.ModifyNode("num1008", Request.Form["eighttd"]);
                opXML.ModifyNode("num1009", Request.Form["ninetd"]);
                opXML.ModifyNode("num1010", Request.Form["tentd"]);
                opXML.ModifyNode("num1011", Request.Form["ycll"]);
                opXML.ModifyNode("num1012", Request.Form["ecll"]);
                opXML.ModifyNode("num1013", Request.Form["scll"]);
                opXML.ModifyNode("num3501", Request.Form["yitongdao"]);
                opXML.ModifyNode("num3502", Request.Form["ertongdao"]);
                opXML.ModifyNode("num3503", Request.Form["santongdao"]);
                opXML.ModifyNode("num3504", Request.Form["sitongdao"]);
                opXML.ModifyNode("num3505", Request.Form["wutongdao"]);
                opXML.ModifyNode("num3506", Request.Form["liutongdao"]);
                opXML.ModifyNode("num3507", Request.Form["qitongdao"]);
                opXML.ModifyNode("num3508", Request.Form["batongdao"]);
                opXML.ModifyNode("num3509", Request.Form["jiutongdao"]);
                opXML.ModifyNode("num3510", Request.Form["shitongdao"]);
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