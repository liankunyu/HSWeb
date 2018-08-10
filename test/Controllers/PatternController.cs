using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class PatternController : Controller
    {
        // GET: Pattern
        public ActionResult Pattern()
        {
            return View();
        }
        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] pattern = new string[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, "name.xml");
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            pattern[1] = opXML.QueryNodeText("name1");
            pattern[2] = opXML.QueryNodeText("name2");
            pattern[3] = opXML.QueryNodeText("name3");
            pattern[4] = opXML.QueryNodeText("name4");
            pattern[5] = opXML.QueryNodeText("name5");
            pattern[6] = opXML.QueryNodeText("name6");
            pattern[7] = opXML.QueryNodeText("name7");
            pattern[8] = opXML.QueryNodeText("name8");
            pattern[9] = opXML.QueryNodeText("name9");
            pattern[10] = opXML.QueryNodeText("name10");
            pattern[11] = opXML.QueryNodeText("name11");
            pattern[12] = opXML.QueryNodeText("name12");
            pattern[13] = opXML.QueryNodeText("name13");
            pattern[14] = opXML.QueryNodeText("name14");
            pattern[15] = opXML.QueryNodeText("name15");
            pattern[16] = opXML.QueryNodeText("name16");
            pattern[17] = opXML.QueryNodeText("name17");

            json = "{\"p1\":\"" + pattern[1] + "\","
             + "\"p2\":\"" + pattern[2] + "\","
             + "\"p3\":\"" + pattern[3] + "\","
             + "\"p4\":\"" + pattern[4] + "\","
             + "\"p5\":\"" + pattern[5] + "\","
             + "\"p6\":\"" + pattern[6] + "\","
             + "\"p7\":\"" + pattern[7] + "\","
             + "\"p8\":\"" + pattern[8] + "\","
             + "\"p9\":\"" + pattern[9] + "\","
             + "\"p10\":\"" + pattern[10] + "\","
             + "\"p11\":\"" + pattern[11] + "\","
             + "\"p12\":\"" + pattern[12] + "\","
             + "\"p13\":\"" + pattern[13] + "\","
             + "\"p14\":\"" + pattern[14] + "\","
             + "\"p15\":\"" + pattern[15] + "\","
             + "\"p96\":\"" + pattern[16] + "\","
             + "\"p97\":\"" + pattern[17] + "\"}";
           
            return Content(json);

        }

        //public ActionResult Read(string name)

        //{
        //    string hs_sql = "select pathName from DeviceInfo where DeviceID='" + test.common.deviceID + "'";
        //    string path = DbHelperSQL.ExecuteQuery(hs_sql);
        //    string newPath = System.IO.Path.Combine(path, name);
        //    newPath = newPath + ".xml";
        //    test.common.ReadXML(newPath);
        //    return Content("Success");
        //}
        public ActionResult Write()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath,name;
            string[] pattern = new string[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            name = Request.Form["name"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath += ".xml";
            name= System.IO.Path.Combine(path, name);
            name += ".xml";
            try
            {
                //c#实现把一个文件从一个文件夹复制到另外一个文件夹并改名
                System.IO.File.Copy(newPath, name, true);//允许覆盖目的地的同名文件
                return Content("Success");
            }
            catch 
            {
                return Content("Nodata");
            }
        }
    }
}