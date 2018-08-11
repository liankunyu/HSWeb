using DA;
using System;
using System.Collections.Generic;
using System.IO;
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
            string[] fileTime = new string[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, "name.xml");
            //读取各个文件上传时间和name.xml值
            try
            {
                FileInfo fi;
                fi = new FileInfo(path + @"\lasttime.xml");
                fileTime[0] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode1.xml");
                fileTime[1] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode2.xml");
                fileTime[2] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode3.xml");
                fileTime[3] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode4.xml");
                fileTime[4] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode5.xml");
                fileTime[5] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode6.xml");
                fileTime[6] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode7.xml");
                fileTime[7] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode8.xml");
                fileTime[8] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode9.xml");
                fileTime[9] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode10.xml");
                fileTime[10] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode11.xml");
                fileTime[11] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode12.xml");
                fileTime[12] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode13.xml");
                fileTime[13] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode14.xml");
                fileTime[14] = fi.LastWriteTime.ToString();
                fi = new FileInfo(path + @"\mode15.xml");
                fileTime[15] = fi.LastWriteTime.ToString();
            }
            catch 
            {
            	
            }
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
            pattern[16] = opXML.QueryNodeText("name96");
            pattern[17] = opXML.QueryNodeText("name97");

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
             + "\"p96\":\"" + pattern[17] + "\","

             + "\"time1\":\"" + fileTime[1] + "\","
             + "\"time2\":\"" + fileTime[2] + "\","
             + "\"time3\":\"" + fileTime[3] + "\","
             + "\"time4\":\"" + fileTime[4] + "\","
             + "\"time5\":\"" + fileTime[5] + "\","
             + "\"time6\":\"" + fileTime[6] + "\","
             + "\"time7\":\"" + fileTime[7] + "\","
             + "\"time8\":\"" + fileTime[8] + "\","
             + "\"time9\":\"" + fileTime[9] + "\","
             + "\"time10\":\"" + fileTime[10] + "\","
             + "\"time11\":\"" + fileTime[11] + "\","
             + "\"time12\":\"" + fileTime[12] + "\","
             + "\"time13\":\"" + fileTime[13] + "\","
             + "\"time14\":\"" + fileTime[14] + "\","
             + "\"time15\":\"" + fileTime[15] + "\","
             + "\"time0\":\"" + fileTime[0] + "\"}";
           
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