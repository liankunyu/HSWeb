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
    public class AreaSetController : Controller
    {
        // GET: AreaSet
        public ActionResult AreaSet()
        {
            return View();
        }

        public ActionResult SendData()
        {       
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] mian = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            mian[1] = opXML.QueryNodeText("num1101");
            mian[2] = opXML.QueryNodeText("num1102");
            mian[3] = opXML.QueryNodeText("num1103");
            mian[4] = opXML.QueryNodeText("num1104");
            mian[5] = opXML.QueryNodeText("num1105");
            mian[6] = opXML.QueryNodeText("num1106");
            mian[7] = opXML.QueryNodeText("num1107");
            mian[8] = opXML.QueryNodeText("num1108");
            mian[9] = opXML.QueryNodeText("num1109");
            mian[10] = opXML.QueryNodeText("num1110");
            mian[11] = opXML.QueryNodeText("num1111");
            mian[12] = opXML.QueryNodeText("num1112");
            mian[13] = opXML.QueryNodeText("num1113");
            mian[14] = opXML.QueryNodeText("num1114");
            mian[15] = opXML.QueryNodeText("num1115");
            mian[16] = opXML.QueryNodeText("num1116");
            mian[17] = opXML.QueryNodeText("num1117");
            mian[18] = opXML.QueryNodeText("num1118");

            json = "{\"mian1\":\"" + mian[1] + "\","
                          + "\"mian2\":\"" + mian[2] + "\","
                          + "\"mian3\":\"" + mian[3] + "\","
                          + "\"mian4\":\"" + mian[4] + "\","
                          + "\"mian5\":\"" + mian[5] + "\","
                          + "\"mian6\":\"" + mian[6] + "\","
                          + "\"mian7\":\"" + mian[7] + "\","
                          + "\"mian8\":\"" + mian[8] + "\","
                          + "\"mian9\":\"" + mian[9] + "\","
                          + "\"mian10\":\"" + mian[10] + "\","
                          + "\"mian11\":\"" + mian[11] + "\","
                          + "\"mian12\":\"" + mian[12] + "\","
                          + "\"mian13\":\"" + mian[13] + "\","
                          + "\"mian14\":\"" + mian[14] + "\","
                          + "\"mian15\":\"" + mian[15] + "\","
                          + "\"mian16\":\"" + mian[16] + "\","
                          + "\"mian17\":\"" + mian[17] + "\","
                          + "\"mian18\":\"" + mian[18] + "\"}";
            return Content(json);
        }

        //面积设定写
        public ActionResult postData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[30];
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
                ROV[1] = opXML.ModifyNode("num1101", Request.Form["mian1"]);
                ROV[2] = opXML.ModifyNode("num1102", Request.Form["mian2"]);
                ROV[3] = opXML.ModifyNode("num1103", Request.Form["mian3"]);
                ROV[4] = opXML.ModifyNode("num1104", Request.Form["mian4"]);
                ROV[5] = opXML.ModifyNode("num1105", Request.Form["mian5"]);
                ROV[6] = opXML.ModifyNode("num1106", Request.Form["mian6"]);
                ROV[7] = opXML.ModifyNode("num1107", Request.Form["mian7"]);
                ROV[8] = opXML.ModifyNode("num1108", Request.Form["mian8"]);
                ROV[9] = opXML.ModifyNode("num1109", Request.Form["mian9"]);
                ROV[10] = opXML.ModifyNode("num1110", Request.Form["mian10"]);
                ROV[11] = opXML.ModifyNode("num1111", Request.Form["mian11"]);
                ROV[12] = opXML.ModifyNode("num1112", Request.Form["mian12"]);
                ROV[13] = opXML.ModifyNode("num1113", Request.Form["mian13"]);
                ROV[14] = opXML.ModifyNode("num1114", Request.Form["mian14"]);
                ROV[15] = opXML.ModifyNode("num1115", Request.Form["mian15"]);
                ROV[16] = opXML.ModifyNode("num1116", Request.Form["mian16"]);
                ROV[17] = opXML.ModifyNode("num1117", Request.Form["mian17"]);
                ROV[18] = opXML.ModifyNode("num1118", Request.Form["mian18"]);
                ROV[19] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 20; i++)
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