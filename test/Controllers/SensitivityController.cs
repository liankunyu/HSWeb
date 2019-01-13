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
    public class SensitivityController : Controller
    {
        
        public ActionResult Sensitivity()
        {
            return View();
        }

        // 树形加载
        public ActionResult rlingmin()
        {
            return View();
        }
        public ActionResult glingmin()
        {
            return View();
        }
        public ActionResult blingmin()
        {
            return View();
        }
        public ActionResult hslingmin()
        {
            return View();
        }

        public ActionResult rlingminf()
        {
            return View();
        }
        public ActionResult glingminf()
        {
            return View();
        }
        public ActionResult blingminf()
        {
            return View();
        }
        public ActionResult hslingminf()
        {
            return View();
        }
        //灵敏度读
        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] rlingmin = new string[20];
            string[] glingmin = new string[20];
            string[] blingmin = new string[20];
            string[] hunlingmin = new string[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            rlingmin[1] = opXML.QueryNodeText("num1501");
            rlingmin[2] = opXML.QueryNodeText("num1502");
            rlingmin[3] = opXML.QueryNodeText("num1503");
            rlingmin[4] = opXML.QueryNodeText("num1504");
            rlingmin[5] = opXML.QueryNodeText("num1505");
            rlingmin[6] = opXML.QueryNodeText("num1506");
            rlingmin[7] = opXML.QueryNodeText("num1507");
            rlingmin[8] = opXML.QueryNodeText("num1508");
            rlingmin[9] = opXML.QueryNodeText("num1509");
            rlingmin[10] = opXML.QueryNodeText("num1510");
            rlingmin[11] = opXML.QueryNodeText("num1511");
            rlingmin[12] = opXML.QueryNodeText("num1512");

            glingmin[1] = opXML.QueryNodeText("num0701");
            glingmin[2] = opXML.QueryNodeText("num0702");
            glingmin[3] = opXML.QueryNodeText("num0703");
            glingmin[4] = opXML.QueryNodeText("num0704");
            glingmin[5] = opXML.QueryNodeText("num0705");
            glingmin[6] = opXML.QueryNodeText("num0706");
            glingmin[7] = opXML.QueryNodeText("num0707");
            glingmin[8] = opXML.QueryNodeText("num0708");
            glingmin[9] = opXML.QueryNodeText("num0709");
            glingmin[10] = opXML.QueryNodeText("num0710");
            glingmin[11] = opXML.QueryNodeText("num0711");
            glingmin[12] = opXML.QueryNodeText("num0712");

            blingmin[1] = opXML.QueryNodeText("num0201");
            blingmin[2] = opXML.QueryNodeText("num0202");
            blingmin[3] = opXML.QueryNodeText("num0203");
            blingmin[4] = opXML.QueryNodeText("num0204");
            blingmin[5] = opXML.QueryNodeText("num0205");
            blingmin[6] = opXML.QueryNodeText("num0206");
            blingmin[7] = opXML.QueryNodeText("num0207");
            blingmin[8] = opXML.QueryNodeText("num0208");
            blingmin[9] = opXML.QueryNodeText("num0209");
            blingmin[10] = opXML.QueryNodeText("num0210");
            blingmin[11] = opXML.QueryNodeText("num0211");
            blingmin[12] = opXML.QueryNodeText("num0212");

            hunlingmin[1] = opXML.QueryNodeText("num0901");
            hunlingmin[2] = opXML.QueryNodeText("num0902");
            hunlingmin[3] = opXML.QueryNodeText("num0903");
            hunlingmin[4] = opXML.QueryNodeText("num0904");
            hunlingmin[5] = opXML.QueryNodeText("num0905");
            hunlingmin[6] = opXML.QueryNodeText("num0906");
            hunlingmin[7] = opXML.QueryNodeText("num0907");
            hunlingmin[8] = opXML.QueryNodeText("num0908");
            hunlingmin[9] = opXML.QueryNodeText("num0909");
            hunlingmin[10] = opXML.QueryNodeText("num0910");
            hunlingmin[11] = opXML.QueryNodeText("num0911");
            hunlingmin[12] = opXML.QueryNodeText("num0912");

            json = "{\"rlingmin1\":\"" + rlingmin[1] + "\","
                          + "\"rlingmin2\":\"" + rlingmin[2] + "\","
                          + "\"rlingmin3\":\"" + rlingmin[3] + "\","
                          + "\"rlingmin4\":\"" + rlingmin[4] + "\","
                          + "\"rlingmin5\":\"" + rlingmin[5] + "\","
                          + "\"rlingmin6\":\"" + rlingmin[6] + "\","
                          + "\"rlingmin7\":\"" + rlingmin[7] + "\","
                          + "\"rlingmin8\":\"" + rlingmin[8] + "\","
                          + "\"rlingmin9\":\"" + rlingmin[9] + "\","
                          + "\"rlingmin10\":\"" + rlingmin[10] + "\","
                          + "\"rlingmin11\":\"" + rlingmin[11] + "\","
                          + "\"rlingmin12\":\"" + rlingmin[12] + "\","

                          + "\"glingmin1\":\"" + glingmin[1] + "\","
                          + "\"glingmin2\":\"" + glingmin[2] + "\","
                          + "\"glingmin3\":\"" + glingmin[3] + "\","
                          + "\"glingmin4\":\"" + glingmin[4] + "\","
                          + "\"glingmin5\":\"" + glingmin[5] + "\","
                          + "\"glingmin6\":\"" + glingmin[6] + "\","
                          + "\"glingmin7\":\"" + glingmin[7] + "\","
                          + "\"glingmin8\":\"" + glingmin[8] + "\","
                          + "\"glingmin9\":\"" + glingmin[9] + "\","
                          + "\"glingmin10\":\"" + glingmin[10] + "\","
                          + "\"glingmin11\":\"" + glingmin[11] + "\","
                          + "\"glingmin12\":\"" + glingmin[12] + "\","

                          + "\"blingmin1\":\"" + blingmin[1] + "\","
                          + "\"blingmin2\":\"" + blingmin[2] + "\","
                          + "\"blingmin3\":\"" + blingmin[3] + "\","
                          + "\"blingmin4\":\"" + blingmin[4] + "\","
                          + "\"blingmin5\":\"" + blingmin[5] + "\","
                          + "\"blingmin6\":\"" + blingmin[6] + "\","
                          + "\"blingmin7\":\"" + blingmin[7] + "\","
                          + "\"blingmin8\":\"" + blingmin[8] + "\","
                          + "\"blingmin9\":\"" + blingmin[9] + "\","
                          + "\"blingmin10\":\"" + blingmin[10] + "\","
                          + "\"blingmin11\":\"" + blingmin[11] + "\","
                          + "\"blingmin12\":\"" + blingmin[12] + "\","

                          + "\"hunlingmin1\":\"" + hunlingmin[1] + "\","
                          + "\"hunlingmin2\":\"" + hunlingmin[2] + "\","
                          + "\"hunlingmin3\":\"" + hunlingmin[3] + "\","
                          + "\"hunlingmin4\":\"" + hunlingmin[4] + "\","
                          + "\"hunlingmin5\":\"" + hunlingmin[5] + "\","
                          + "\"hunlingmin6\":\"" + hunlingmin[6] + "\","
                          + "\"hunlingmin7\":\"" + hunlingmin[7] + "\","
                          + "\"hunlingmin8\":\"" + hunlingmin[8] + "\","
                          + "\"hunlingmin9\":\"" + hunlingmin[9] + "\","
                          + "\"hunlingmin10\":\"" + hunlingmin[10] + "\","
                          + "\"hunlingmin11\":\"" + hunlingmin[11] + "\","
                          + "\"hunlingmin12\":\"" + hunlingmin[12] + "\"}";
            return Content(json);
        }

        //R灵敏度写
        public ActionResult RpostData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num1501", Request.Form["rlingmin1"]);
                ROV[2] = opXML.ModifyNode("num1502", Request.Form["rlingmin2"]);
                ROV[3] = opXML.ModifyNode("num1503", Request.Form["rlingmin3"]);
                ROV[4] = opXML.ModifyNode("num1504", Request.Form["rlingmin4"]);
                ROV[5] = opXML.ModifyNode("num1505", Request.Form["rlingmin5"]);
                ROV[6] = opXML.ModifyNode("num1506", Request.Form["rlingmin6"]);
                ROV[7] = opXML.ModifyNode("num1507", Request.Form["rlingmin7"]);
                ROV[8] = opXML.ModifyNode("num1508", Request.Form["rlingmin8"]);
                ROV[9] = opXML.ModifyNode("num1509", Request.Form["rlingmin9"]);
                ROV[10] = opXML.ModifyNode("num1510", Request.Form["rlingmin10"]);
                ROV[11] = opXML.ModifyNode("num1511", Request.Form["rlingmin11"]);
                ROV[12] = opXML.ModifyNode("num1512", Request.Form["rlingmin12"]);
                ROV[13] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 14; i++)
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
        //G灵敏度写
        public ActionResult GpostData()
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
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                opXML.ModifyNode("num0701", Request.Form["glingmin1"]);
                opXML.ModifyNode("num0702", Request.Form["glingmin2"]);
                opXML.ModifyNode("num0703", Request.Form["glingmin3"]);
                opXML.ModifyNode("num0704", Request.Form["glingmin4"]);
                opXML.ModifyNode("num0705", Request.Form["glingmin5"]);
                opXML.ModifyNode("num0706", Request.Form["glingmin6"]);
                opXML.ModifyNode("num0707", Request.Form["glingmin7"]);
                opXML.ModifyNode("num0708", Request.Form["glingmin8"]);
                opXML.ModifyNode("num0709", Request.Form["glingmin9"]);
                opXML.ModifyNode("num0710", Request.Form["glingmin10"]);
                opXML.ModifyNode("num0711", Request.Form["glingmin11"]);
                opXML.ModifyNode("num0712", Request.Form["glingmin12"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }
        //B灵敏度写
        public ActionResult BpostData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num0201", Request.Form["blingmin1"]);
                ROV[2] = opXML.ModifyNode("num0202", Request.Form["blingmin2"]);
                ROV[3] = opXML.ModifyNode("num0203", Request.Form["blingmin3"]);
                ROV[4] = opXML.ModifyNode("num0204", Request.Form["blingmin4"]);
                ROV[5] = opXML.ModifyNode("num0205", Request.Form["blingmin5"]);
                ROV[6] = opXML.ModifyNode("num0206", Request.Form["blingmin6"]);
                ROV[7] = opXML.ModifyNode("num0207", Request.Form["blingmin7"]);
                ROV[8] = opXML.ModifyNode("num0208", Request.Form["blingmin8"]);
                ROV[9] = opXML.ModifyNode("num0209", Request.Form["blingmin9"]);
                ROV[10] = opXML.ModifyNode("num0210", Request.Form["blingmin10"]);
                ROV[11] = opXML.ModifyNode("num0211", Request.Form["blingmin11"]);
                ROV[12] = opXML.ModifyNode("num0212", Request.Form["blingmin12"]);
                ROV[13] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 14; i++)
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
        //混色灵敏度写
        public ActionResult HpostData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num0901", Request.Form["hunlingmin1"]);
                ROV[2] = opXML.ModifyNode("num0902", Request.Form["hunlingmin2"]);
                ROV[3] = opXML.ModifyNode("num0903", Request.Form["hunlingmin3"]);
                ROV[4] = opXML.ModifyNode("num0904", Request.Form["hunlingmin4"]);
                ROV[5] = opXML.ModifyNode("num0905", Request.Form["hunlingmin5"]);
                ROV[6] = opXML.ModifyNode("num0906", Request.Form["hunlingmin6"]);
                ROV[7] = opXML.ModifyNode("num0907", Request.Form["hunlingmin7"]);
                ROV[8] = opXML.ModifyNode("num0908", Request.Form["hunlingmin8"]);
                ROV[9] = opXML.ModifyNode("num0909", Request.Form["hunlingmin9"]);
                ROV[10] = opXML.ModifyNode("num0910", Request.Form["hunlingmin10"]);
                ROV[11] = opXML.ModifyNode("num0911", Request.Form["hunlingmin11"]);
                ROV[12] = opXML.ModifyNode("num0912", Request.Form["hunlingmin12"]);
                ROV[13] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 14; i++)
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


        //R灵敏度分量读
        public ActionResult SendDataR()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] rlingminf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            rlingminf[1] = opXML.QueryNodeText("num3801");
            rlingminf[2] = opXML.QueryNodeText("num3802");
            rlingminf[3] = opXML.QueryNodeText("num3803");
            rlingminf[4] = opXML.QueryNodeText("num3804");
            rlingminf[5] = opXML.QueryNodeText("num3805");
            rlingminf[6] = opXML.QueryNodeText("num3806");
            rlingminf[7] = opXML.QueryNodeText("num3807");
            rlingminf[8] = opXML.QueryNodeText("num3808");
            rlingminf[9] = opXML.QueryNodeText("num3809");
            rlingminf[10] = opXML.QueryNodeText("num3810");
            rlingminf[11] = opXML.QueryNodeText("num3811");
            rlingminf[12] = opXML.QueryNodeText("num3812");
            rlingminf[13] = opXML.QueryNodeText("num3813");
            rlingminf[14] = opXML.QueryNodeText("num3814");
            rlingminf[15] = opXML.QueryNodeText("num3815");
            rlingminf[16] = opXML.QueryNodeText("num3816");
            rlingminf[17] = opXML.QueryNodeText("num3817");
            rlingminf[18] = opXML.QueryNodeText("num3818");
            rlingminf[19] = opXML.QueryNodeText("num3819");
            rlingminf[20] = opXML.QueryNodeText("num3820");
            rlingminf[21] = opXML.QueryNodeText("num3821");
            rlingminf[22] = opXML.QueryNodeText("num3822");
            rlingminf[23] = opXML.QueryNodeText("num3823");
            rlingminf[24] = opXML.QueryNodeText("num3824");
            rlingminf[25] = opXML.QueryNodeText("num3825");
            rlingminf[26] = opXML.QueryNodeText("num3826");
            rlingminf[27] = opXML.QueryNodeText("num3827");
            rlingminf[28] = opXML.QueryNodeText("num3828");
            rlingminf[29] = opXML.QueryNodeText("num3829");
            rlingminf[30] = opXML.QueryNodeText("num3830");
            rlingminf[31] = opXML.QueryNodeText("num3831");
            rlingminf[32] = opXML.QueryNodeText("num3832");
            rlingminf[33] = opXML.QueryNodeText("num3833");
            rlingminf[34] = opXML.QueryNodeText("num3834");
            rlingminf[35] = opXML.QueryNodeText("num3835");
            rlingminf[36] = opXML.QueryNodeText("num3836");
            rlingminf[37] = opXML.QueryNodeText("num3837");
            rlingminf[38] = opXML.QueryNodeText("num3838");
            rlingminf[39] = opXML.QueryNodeText("num3839");
            rlingminf[40] = opXML.QueryNodeText("num3840");

            json = "{\"rlingminf1\":\"" + rlingminf[1] + "\","
                          + "\"rlingminf2\":\"" + rlingminf[2] + "\","
                          + "\"rlingminf3\":\"" + rlingminf[3] + "\","
                          + "\"rlingminf4\":\"" + rlingminf[4] + "\","
                          + "\"rlingminf5\":\"" + rlingminf[5] + "\","
                          + "\"rlingminf6\":\"" + rlingminf[6] + "\","
                          + "\"rlingminf7\":\"" + rlingminf[7] + "\","
                          + "\"rlingminf8\":\"" + rlingminf[8] + "\","
                          + "\"rlingminf9\":\"" + rlingminf[9] + "\","
                          + "\"rlingminf10\":\"" + rlingminf[10] + "\","
                          + "\"rlingminf11\":\"" + rlingminf[11] + "\","
                          + "\"rlingminf12\":\"" + rlingminf[12] + "\","
                          + "\"rlingminf13\":\"" + rlingminf[13] + "\","
                          + "\"rlingminf14\":\"" + rlingminf[14] + "\","
                          + "\"rlingminf15\":\"" + rlingminf[15] + "\","
                          + "\"rlingminf16\":\"" + rlingminf[16] + "\","
                          + "\"rlingminf17\":\"" + rlingminf[17] + "\","
                          + "\"rlingminf18\":\"" + rlingminf[18] + "\","
                          + "\"rlingminf19\":\"" + rlingminf[19] + "\","
                          + "\"rlingminf20\":\"" + rlingminf[20] + "\","
                          + "\"rlingminf21\":\"" + rlingminf[21] + "\","
                          + "\"rlingminf22\":\"" + rlingminf[22] + "\","
                          + "\"rlingminf23\":\"" + rlingminf[23] + "\","
                          + "\"rlingminf24\":\"" + rlingminf[24] + "\","
                          + "\"rlingminf25\":\"" + rlingminf[25] + "\","
                          + "\"rlingminf26\":\"" + rlingminf[26] + "\","
                          + "\"rlingminf27\":\"" + rlingminf[27] + "\","
                          + "\"rlingminf28\":\"" + rlingminf[28] + "\","
                          + "\"rlingminf29\":\"" + rlingminf[29] + "\","
                          + "\"rlingminf30\":\"" + rlingminf[30] + "\","
                          + "\"rlingminf31\":\"" + rlingminf[31] + "\","
                          + "\"rlingminf32\":\"" + rlingminf[32] + "\","
                          + "\"rlingminf33\":\"" + rlingminf[33] + "\","
                          + "\"rlingminf34\":\"" + rlingminf[34] + "\","
                          + "\"rlingminf35\":\"" + rlingminf[35] + "\","
                          + "\"rlingminf36\":\"" + rlingminf[36] + "\","
                          + "\"rlingminf37\":\"" + rlingminf[37] + "\","
                          + "\"rlingminf38\":\"" + rlingminf[38] + "\","
                          + "\"rlingminf39\":\"" + rlingminf[39] + "\","
                          + "\"rlingminf40\":\"" + rlingminf[40] + "\"}";
            return Content(json);

        }

        //G灵敏度分量读
        public ActionResult SendDataG()
        {
           //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] glingminf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            glingminf[1] = opXML.QueryNodeText("num3701");
            glingminf[2] = opXML.QueryNodeText("num3702");
            glingminf[3] = opXML.QueryNodeText("num3703");
            glingminf[4] = opXML.QueryNodeText("num3704");
            glingminf[5] = opXML.QueryNodeText("num3705");
            glingminf[6] = opXML.QueryNodeText("num3706");
            glingminf[7] = opXML.QueryNodeText("num3707");
            glingminf[8] = opXML.QueryNodeText("num3708");
            glingminf[9] = opXML.QueryNodeText("num3709");
            glingminf[10] = opXML.QueryNodeText("num3710");
            glingminf[11] = opXML.QueryNodeText("num3711");
            glingminf[12] = opXML.QueryNodeText("num3712");
            glingminf[13] = opXML.QueryNodeText("num3713");
            glingminf[14] = opXML.QueryNodeText("num3714");
            glingminf[15] = opXML.QueryNodeText("num3715");
            glingminf[16] = opXML.QueryNodeText("num3716");
            glingminf[17] = opXML.QueryNodeText("num3717");
            glingminf[18] = opXML.QueryNodeText("num3718");
            glingminf[19] = opXML.QueryNodeText("num3719");
            glingminf[20] = opXML.QueryNodeText("num3720");
            glingminf[21] = opXML.QueryNodeText("num3721");
            glingminf[22] = opXML.QueryNodeText("num3722");
            glingminf[23] = opXML.QueryNodeText("num3723");
            glingminf[24] = opXML.QueryNodeText("num3724");
            glingminf[25] = opXML.QueryNodeText("num3725");
            glingminf[26] = opXML.QueryNodeText("num3726");
            glingminf[27] = opXML.QueryNodeText("num3727");
            glingminf[28] = opXML.QueryNodeText("num3728");
            glingminf[29] = opXML.QueryNodeText("num3729");
            glingminf[30] = opXML.QueryNodeText("num3730");
            glingminf[31] = opXML.QueryNodeText("num3731");
            glingminf[32] = opXML.QueryNodeText("num3732");
            glingminf[33] = opXML.QueryNodeText("num3733");
            glingminf[34] = opXML.QueryNodeText("num3734");
            glingminf[35] = opXML.QueryNodeText("num3735");
            glingminf[36] = opXML.QueryNodeText("num3736");
            glingminf[37] = opXML.QueryNodeText("num3737");
            glingminf[38] = opXML.QueryNodeText("num3738");
            glingminf[39] = opXML.QueryNodeText("num3739");
            glingminf[40] = opXML.QueryNodeText("num3740");

            json = "{\"glingminf1\":\"" + glingminf[1] + "\","
                          + "\"glingminf2\":\"" + glingminf[2] + "\","
                          + "\"glingminf3\":\"" + glingminf[3] + "\","
                          + "\"glingminf4\":\"" + glingminf[4] + "\","
                          + "\"glingminf5\":\"" + glingminf[5] + "\","
                          + "\"glingminf6\":\"" + glingminf[6] + "\","
                          + "\"glingminf7\":\"" + glingminf[7] + "\","
                          + "\"glingminf8\":\"" + glingminf[8] + "\","
                          + "\"glingminf9\":\"" + glingminf[9] + "\","
                          + "\"glingminf10\":\"" + glingminf[10] + "\","
                          + "\"glingminf11\":\"" + glingminf[11] + "\","
                          + "\"glingminf12\":\"" + glingminf[12] + "\","
                          + "\"glingminf13\":\"" + glingminf[13] + "\","
                          + "\"glingminf14\":\"" + glingminf[14] + "\","
                          + "\"glingminf15\":\"" + glingminf[15] + "\","
                          + "\"glingminf16\":\"" + glingminf[16] + "\","
                          + "\"glingminf17\":\"" + glingminf[17] + "\","
                          + "\"glingminf18\":\"" + glingminf[18] + "\","
                          + "\"glingminf19\":\"" + glingminf[19] + "\","
                          + "\"glingminf20\":\"" + glingminf[20] + "\","
                          + "\"glingminf21\":\"" + glingminf[21] + "\","
                          + "\"glingminf22\":\"" + glingminf[22] + "\","
                          + "\"glingminf23\":\"" + glingminf[23] + "\","
                          + "\"glingminf24\":\"" + glingminf[24] + "\","
                          + "\"glingminf25\":\"" + glingminf[25] + "\","
                          + "\"glingminf26\":\"" + glingminf[26] + "\","
                          + "\"glingminf27\":\"" + glingminf[27] + "\","
                          + "\"glingminf28\":\"" + glingminf[28] + "\","
                          + "\"glingminf29\":\"" + glingminf[29] + "\","
                          + "\"glingminf30\":\"" + glingminf[30] + "\","
                          + "\"glingminf31\":\"" + glingminf[31] + "\","
                          + "\"glingminf32\":\"" + glingminf[32] + "\","
                          + "\"glingminf33\":\"" + glingminf[33] + "\","
                          + "\"glingminf34\":\"" + glingminf[34] + "\","
                          + "\"glingminf35\":\"" + glingminf[35] + "\","
                          + "\"glingminf36\":\"" + glingminf[36] + "\","
                          + "\"glingminf37\":\"" + glingminf[37] + "\","
                          + "\"glingminf38\":\"" + glingminf[38] + "\","
                          + "\"glingminf39\":\"" + glingminf[39] + "\","
                          + "\"glingminf40\":\"" + glingminf[40] + "\"}";
            return Content(json);

        }

        //B灵敏度分量读
        public ActionResult SendDataB()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] blingminf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            blingminf[1] = opXML.QueryNodeText("num3601");
            blingminf[2] = opXML.QueryNodeText("num3602");
            blingminf[3] = opXML.QueryNodeText("num3603");
            blingminf[4] = opXML.QueryNodeText("num3604");
            blingminf[5] = opXML.QueryNodeText("num3605");
            blingminf[6] = opXML.QueryNodeText("num3606");
            blingminf[7] = opXML.QueryNodeText("num3607");
            blingminf[8] = opXML.QueryNodeText("num3608");
            blingminf[9] = opXML.QueryNodeText("num3609");
            blingminf[10] = opXML.QueryNodeText("num3610");
            blingminf[11] = opXML.QueryNodeText("num3611");
            blingminf[12] = opXML.QueryNodeText("num3612");
            blingminf[13] = opXML.QueryNodeText("num3613");
            blingminf[14] = opXML.QueryNodeText("num3614");
            blingminf[15] = opXML.QueryNodeText("num3615");
            blingminf[16] = opXML.QueryNodeText("num3616");
            blingminf[17] = opXML.QueryNodeText("num3617");
            blingminf[18] = opXML.QueryNodeText("num3618");
            blingminf[19] = opXML.QueryNodeText("num3619");
            blingminf[20] = opXML.QueryNodeText("num3620");
            blingminf[21] = opXML.QueryNodeText("num3621");
            blingminf[22] = opXML.QueryNodeText("num3622");
            blingminf[23] = opXML.QueryNodeText("num3623");
            blingminf[24] = opXML.QueryNodeText("num3624");
            blingminf[25] = opXML.QueryNodeText("num3625");
            blingminf[26] = opXML.QueryNodeText("num3626");
            blingminf[27] = opXML.QueryNodeText("num3627");
            blingminf[28] = opXML.QueryNodeText("num3628");
            blingminf[29] = opXML.QueryNodeText("num3629");
            blingminf[30] = opXML.QueryNodeText("num3630");
            blingminf[31] = opXML.QueryNodeText("num3631");
            blingminf[32] = opXML.QueryNodeText("num3632");
            blingminf[33] = opXML.QueryNodeText("num3633");
            blingminf[34] = opXML.QueryNodeText("num3634");
            blingminf[35] = opXML.QueryNodeText("num3635");
            blingminf[36] = opXML.QueryNodeText("num3636");
            blingminf[37] = opXML.QueryNodeText("num3637");
            blingminf[38] = opXML.QueryNodeText("num3638");
            blingminf[39] = opXML.QueryNodeText("num3639");
            blingminf[40] = opXML.QueryNodeText("num3640");

            json = "{\"blingminf1\":\"" + blingminf[1] + "\","
                          + "\"blingminf2\":\"" + blingminf[2] + "\","
                          + "\"blingminf3\":\"" + blingminf[3] + "\","
                          + "\"blingminf4\":\"" + blingminf[4] + "\","
                          + "\"blingminf5\":\"" + blingminf[5] + "\","
                          + "\"blingminf6\":\"" + blingminf[6] + "\","
                          + "\"blingminf7\":\"" + blingminf[7] + "\","
                          + "\"blingminf8\":\"" + blingminf[8] + "\","
                          + "\"blingminf9\":\"" + blingminf[9] + "\","
                          + "\"blingminf10\":\"" + blingminf[10] + "\","
                          + "\"blingminf11\":\"" + blingminf[11] + "\","
                          + "\"blingminf12\":\"" + blingminf[12] + "\","
                          + "\"blingminf13\":\"" + blingminf[13] + "\","
                          + "\"blingminf14\":\"" + blingminf[14] + "\","
                          + "\"blingminf15\":\"" + blingminf[15] + "\","
                          + "\"blingminf16\":\"" + blingminf[16] + "\","
                          + "\"blingminf17\":\"" + blingminf[17] + "\","
                          + "\"blingminf18\":\"" + blingminf[18] + "\","
                          + "\"blingminf19\":\"" + blingminf[19] + "\","
                          + "\"blingminf20\":\"" + blingminf[20] + "\","
                          + "\"blingminf21\":\"" + blingminf[21] + "\","
                          + "\"blingminf22\":\"" + blingminf[22] + "\","
                          + "\"blingminf23\":\"" + blingminf[23] + "\","
                          + "\"blingminf24\":\"" + blingminf[24] + "\","
                          + "\"blingminf25\":\"" + blingminf[25] + "\","
                          + "\"blingminf26\":\"" + blingminf[26] + "\","
                          + "\"blingminf27\":\"" + blingminf[27] + "\","
                          + "\"blingminf28\":\"" + blingminf[28] + "\","
                          + "\"blingminf29\":\"" + blingminf[29] + "\","
                          + "\"blingminf30\":\"" + blingminf[30] + "\","
                          + "\"blingminf31\":\"" + blingminf[31] + "\","
                          + "\"blingminf32\":\"" + blingminf[32] + "\","
                          + "\"blingminf33\":\"" + blingminf[33] + "\","
                          + "\"blingminf34\":\"" + blingminf[34] + "\","
                          + "\"blingminf35\":\"" + blingminf[35] + "\","
                          + "\"blingminf36\":\"" + blingminf[36] + "\","
                          + "\"blingminf37\":\"" + blingminf[37] + "\","
                          + "\"blingminf38\":\"" + blingminf[38] + "\","
                          + "\"blingminf39\":\"" + blingminf[39] + "\","
                          + "\"blingminf40\":\"" + blingminf[40] + "\"}";
            return Content(json);

        }

        //混色灵敏度分量读
        public ActionResult SendDataHS()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] hunlingminf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            hunlingminf[1] = opXML.QueryNodeText("num3901");
            hunlingminf[2] = opXML.QueryNodeText("num3902");
            hunlingminf[3] = opXML.QueryNodeText("num3903");
            hunlingminf[4] = opXML.QueryNodeText("num3904");
            hunlingminf[5] = opXML.QueryNodeText("num3905");
            hunlingminf[6] = opXML.QueryNodeText("num3906");
            hunlingminf[7] = opXML.QueryNodeText("num3907");
            hunlingminf[8] = opXML.QueryNodeText("num3908");
            hunlingminf[9] = opXML.QueryNodeText("num3909");
            hunlingminf[10] = opXML.QueryNodeText("num3910");
            hunlingminf[11] = opXML.QueryNodeText("num3911");
            hunlingminf[12] = opXML.QueryNodeText("num3912");
            hunlingminf[13] = opXML.QueryNodeText("num3913");
            hunlingminf[14] = opXML.QueryNodeText("num3914");
            hunlingminf[15] = opXML.QueryNodeText("num3915");
            hunlingminf[16] = opXML.QueryNodeText("num3916");
            hunlingminf[17] = opXML.QueryNodeText("num3917");
            hunlingminf[18] = opXML.QueryNodeText("num3918");
            hunlingminf[19] = opXML.QueryNodeText("num3919");
            hunlingminf[20] = opXML.QueryNodeText("num3920");
            hunlingminf[21] = opXML.QueryNodeText("num3921");
            hunlingminf[22] = opXML.QueryNodeText("num3922");
            hunlingminf[23] = opXML.QueryNodeText("num3923");
            hunlingminf[24] = opXML.QueryNodeText("num3924");
            hunlingminf[25] = opXML.QueryNodeText("num3925");
            hunlingminf[26] = opXML.QueryNodeText("num3926");
            hunlingminf[27] = opXML.QueryNodeText("num3927");
            hunlingminf[28] = opXML.QueryNodeText("num3928");
            hunlingminf[29] = opXML.QueryNodeText("num3929");
            hunlingminf[30] = opXML.QueryNodeText("num3930");
            hunlingminf[31] = opXML.QueryNodeText("num3931");
            hunlingminf[32] = opXML.QueryNodeText("num3932");
            hunlingminf[33] = opXML.QueryNodeText("num3933");
            hunlingminf[34] = opXML.QueryNodeText("num3934");
            hunlingminf[35] = opXML.QueryNodeText("num3935");
            hunlingminf[36] = opXML.QueryNodeText("num3936");
            hunlingminf[37] = opXML.QueryNodeText("num3937");
            hunlingminf[38] = opXML.QueryNodeText("num3938");
            hunlingminf[39] = opXML.QueryNodeText("num3939");
            hunlingminf[40] = opXML.QueryNodeText("num3940");

            json = "{\"hunlingminf1\":\"" + hunlingminf[1] + "\","
                          + "\"hunlingminf2\":\"" + hunlingminf[2] + "\","
                          + "\"hunlingminf3\":\"" + hunlingminf[3] + "\","
                          + "\"hunlingminf4\":\"" + hunlingminf[4] + "\","
                          + "\"hunlingminf5\":\"" + hunlingminf[5] + "\","
                          + "\"hunlingminf6\":\"" + hunlingminf[6] + "\","
                          + "\"hunlingminf7\":\"" + hunlingminf[7] + "\","
                          + "\"hunlingminf8\":\"" + hunlingminf[8] + "\","
                          + "\"hunlingminf9\":\"" + hunlingminf[9] + "\","
                          + "\"hunlingminf10\":\"" + hunlingminf[10] + "\","
                          + "\"hunlingminf11\":\"" + hunlingminf[11] + "\","
                          + "\"hunlingminf12\":\"" + hunlingminf[12] + "\","
                          + "\"hunlingminf13\":\"" + hunlingminf[13] + "\","
                          + "\"hunlingminf14\":\"" + hunlingminf[14] + "\","
                          + "\"hunlingminf15\":\"" + hunlingminf[15] + "\","
                          + "\"hunlingminf16\":\"" + hunlingminf[16] + "\","
                          + "\"hunlingminf17\":\"" + hunlingminf[17] + "\","
                          + "\"hunlingminf18\":\"" + hunlingminf[18] + "\","
                          + "\"hunlingminf19\":\"" + hunlingminf[19] + "\","
                          + "\"hunlingminf20\":\"" + hunlingminf[20] + "\","
                          + "\"hunlingminf21\":\"" + hunlingminf[21] + "\","
                          + "\"hunlingminf22\":\"" + hunlingminf[22] + "\","
                          + "\"hunlingminf23\":\"" + hunlingminf[23] + "\","
                          + "\"hunlingminf24\":\"" + hunlingminf[24] + "\","
                          + "\"hunlingminf25\":\"" + hunlingminf[25] + "\","
                          + "\"hunlingminf26\":\"" + hunlingminf[26] + "\","
                          + "\"hunlingminf27\":\"" + hunlingminf[27] + "\","
                          + "\"hunlingminf28\":\"" + hunlingminf[28] + "\","
                          + "\"hunlingminf29\":\"" + hunlingminf[29] + "\","
                          + "\"hunlingminf30\":\"" + hunlingminf[30] + "\","
                          + "\"hunlingminf31\":\"" + hunlingminf[31] + "\","
                          + "\"hunlingminf32\":\"" + hunlingminf[32] + "\","
                          + "\"hunlingminf33\":\"" + hunlingminf[33] + "\","
                          + "\"hunlingminf34\":\"" + hunlingminf[34] + "\","
                          + "\"hunlingminf35\":\"" + hunlingminf[35] + "\","
                          + "\"hunlingminf36\":\"" + hunlingminf[36] + "\","
                          + "\"hunlingminf37\":\"" + hunlingminf[37] + "\","
                          + "\"hunlingminf38\":\"" + hunlingminf[38] + "\","
                          + "\"hunlingminf39\":\"" + hunlingminf[39] + "\","
                          + "\"hunlingminf40\":\"" + hunlingminf[40] + "\"}";
            return Content(json);
        }

 
        //R灵敏度分量写
        public ActionResult postDataR()
        {
            //声明设备ID，文件名，查询语句，路径，路径
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num3801", Request.Form["rlingminf1"]);
                ROV[2] = opXML.ModifyNode("num3802", Request.Form["rlingminf2"]);
                ROV[3] = opXML.ModifyNode("num3803", Request.Form["rlingminf3"]);
                ROV[4] = opXML.ModifyNode("num3804", Request.Form["rlingminf4"]);
                ROV[5] = opXML.ModifyNode("num3805", Request.Form["rlingminf5"]);
                ROV[6] = opXML.ModifyNode("num3806", Request.Form["rlingminf6"]);
                ROV[7] = opXML.ModifyNode("num3807", Request.Form["rlingminf7"]);
                ROV[8] = opXML.ModifyNode("num3808", Request.Form["rlingminf8"]);
                ROV[9] = opXML.ModifyNode("num3809", Request.Form["rlingminf9"]);
                ROV[10] = opXML.ModifyNode("num3810", Request.Form["rlingminf10"]);
                ROV[11] = opXML.ModifyNode("num3811", Request.Form["rlingminf11"]);
                ROV[12] = opXML.ModifyNode("num3812", Request.Form["rlingminf12"]);
                ROV[13] = opXML.ModifyNode("num3813", Request.Form["rlingminf13"]);
                ROV[14] = opXML.ModifyNode("num3814", Request.Form["rlingminf14"]);
                ROV[15] = opXML.ModifyNode("num3815", Request.Form["rlingminf15"]);
                ROV[16] = opXML.ModifyNode("num3816", Request.Form["rlingminf16"]);
                ROV[17] = opXML.ModifyNode("num3817", Request.Form["rlingminf17"]);
                ROV[18] = opXML.ModifyNode("num3818", Request.Form["rlingminf18"]);
                ROV[19] = opXML.ModifyNode("num3819", Request.Form["rlingminf19"]);
                ROV[20] = opXML.ModifyNode("num3820", Request.Form["rlingminf20"]);
                ROV[21] = opXML.ModifyNode("num3821", Request.Form["rlingminf21"]);
                ROV[22] = opXML.ModifyNode("num3822", Request.Form["rlingminf22"]);
                ROV[23] = opXML.ModifyNode("num3823", Request.Form["rlingminf23"]);
                ROV[24] = opXML.ModifyNode("num3824", Request.Form["rlingminf24"]);
                ROV[25] = opXML.ModifyNode("num3825", Request.Form["rlingminf25"]);
                ROV[26] = opXML.ModifyNode("num3826", Request.Form["rlingminf26"]);
                ROV[27] = opXML.ModifyNode("num3827", Request.Form["rlingminf27"]);
                ROV[28] = opXML.ModifyNode("num3828", Request.Form["rlingminf28"]);
                ROV[29] = opXML.ModifyNode("num3829", Request.Form["rlingminf29"]);
                ROV[30] = opXML.ModifyNode("num3830", Request.Form["rlingminf30"]);
                ROV[31] = opXML.ModifyNode("num3831", Request.Form["rlingminf31"]);
                ROV[32] = opXML.ModifyNode("num3832", Request.Form["rlingminf32"]);
                ROV[33] = opXML.ModifyNode("num3833", Request.Form["rlingminf33"]);
                ROV[34] = opXML.ModifyNode("num3834", Request.Form["rlingminf34"]);
                ROV[35] = opXML.ModifyNode("num3835", Request.Form["rlingminf35"]);
                ROV[36] = opXML.ModifyNode("num3836", Request.Form["rlingminf36"]);
                ROV[37] = opXML.ModifyNode("num3837", Request.Form["rlingminf37"]);
                ROV[38] = opXML.ModifyNode("num3838", Request.Form["rlingminf38"]);
                ROV[39] = opXML.ModifyNode("num3839", Request.Form["rlingminf39"]);
                ROV[40] = opXML.ModifyNode("num3840", Request.Form["rlingminf40"]);
                ROV[41] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 42; i++)
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
        

        //G灵敏度分量写
        public ActionResult postDataG()
        {
            //声明设备ID，文件名，查询语句，路径，路径
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num3701", Request.Form["glingminf1"]);
                ROV[2] = opXML.ModifyNode("num3702", Request.Form["glingminf2"]);
                ROV[3] = opXML.ModifyNode("num3703", Request.Form["glingminf3"]);
                ROV[4] = opXML.ModifyNode("num3704", Request.Form["glingminf4"]);
                ROV[5] = opXML.ModifyNode("num3705", Request.Form["glingminf5"]);
                ROV[6] = opXML.ModifyNode("num3706", Request.Form["glingminf6"]);
                ROV[7] = opXML.ModifyNode("num3707", Request.Form["glingminf7"]);
                ROV[8] = opXML.ModifyNode("num3708", Request.Form["glingminf8"]);
                ROV[9] = opXML.ModifyNode("num3709", Request.Form["glingminf9"]);
                ROV[10] = opXML.ModifyNode("num3710", Request.Form["glingminf10"]);
                ROV[11] = opXML.ModifyNode("num3711", Request.Form["glingminf11"]);
                ROV[12] = opXML.ModifyNode("num3712", Request.Form["glingminf12"]);
                ROV[13] = opXML.ModifyNode("num3713", Request.Form["glingminf13"]);
                ROV[14] = opXML.ModifyNode("num3714", Request.Form["glingminf14"]);
                ROV[15] = opXML.ModifyNode("num3715", Request.Form["glingminf15"]);
                ROV[16] = opXML.ModifyNode("num3716", Request.Form["glingminf16"]);
                ROV[17] = opXML.ModifyNode("num3717", Request.Form["glingminf17"]);
                ROV[18] = opXML.ModifyNode("num3718", Request.Form["glingminf18"]);
                ROV[19] = opXML.ModifyNode("num3719", Request.Form["glingminf19"]);
                ROV[20] = opXML.ModifyNode("num3720", Request.Form["glingminf20"]);
                ROV[21] = opXML.ModifyNode("num3721", Request.Form["glingminf21"]);
                ROV[22] = opXML.ModifyNode("num3722", Request.Form["glingminf22"]);
                ROV[23] = opXML.ModifyNode("num3723", Request.Form["glingminf23"]);
                ROV[24] = opXML.ModifyNode("num3724", Request.Form["glingminf24"]);
                ROV[25] = opXML.ModifyNode("num3725", Request.Form["glingminf25"]);
                ROV[26] = opXML.ModifyNode("num3726", Request.Form["glingminf26"]);
                ROV[27] = opXML.ModifyNode("num3727", Request.Form["glingminf27"]);
                ROV[28] = opXML.ModifyNode("num3728", Request.Form["glingminf28"]);
                ROV[29] = opXML.ModifyNode("num3729", Request.Form["glingminf29"]);
                ROV[30] = opXML.ModifyNode("num3730", Request.Form["glingminf30"]);
                ROV[31] = opXML.ModifyNode("num3731", Request.Form["glingminf31"]);
                ROV[32] = opXML.ModifyNode("num3732", Request.Form["glingminf32"]);
                ROV[33] = opXML.ModifyNode("num3733", Request.Form["glingminf33"]);
                ROV[34] = opXML.ModifyNode("num3734", Request.Form["glingminf34"]);
                ROV[35] = opXML.ModifyNode("num3735", Request.Form["glingminf35"]);
                ROV[36] = opXML.ModifyNode("num3736", Request.Form["glingminf36"]);
                ROV[37] = opXML.ModifyNode("num3737", Request.Form["glingminf37"]);
                ROV[38] = opXML.ModifyNode("num3738", Request.Form["glingminf38"]);
                ROV[39] = opXML.ModifyNode("num3739", Request.Form["glingminf39"]);
                ROV[40] = opXML.ModifyNode("num3740", Request.Form["glingminf40"]);
                ROV[41] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 42; i++)
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

        //B灵敏度分量写
        public ActionResult postDataB()
        {
           //声明设备ID，文件名，查询语句，路径，路径
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num3601", Request.Form["blingminf1"]);
                ROV[2] = opXML.ModifyNode("num3602", Request.Form["blingminf2"]);
                ROV[3] = opXML.ModifyNode("num3603", Request.Form["blingminf3"]);
                ROV[4] = opXML.ModifyNode("num3604", Request.Form["blingminf4"]);
                ROV[5] = opXML.ModifyNode("num3605", Request.Form["blingminf5"]);
                ROV[6] = opXML.ModifyNode("num3606", Request.Form["blingminf6"]);
                ROV[7] = opXML.ModifyNode("num3607", Request.Form["blingminf7"]);
                ROV[8] = opXML.ModifyNode("num3608", Request.Form["blingminf8"]);
                ROV[9] = opXML.ModifyNode("num3609", Request.Form["blingminf9"]);
                ROV[10] = opXML.ModifyNode("num3610", Request.Form["blingminf10"]);
                ROV[11] = opXML.ModifyNode("num3611", Request.Form["blingminf11"]);
                ROV[12] = opXML.ModifyNode("num3612", Request.Form["blingminf12"]);
                ROV[13] = opXML.ModifyNode("num3613", Request.Form["blingminf13"]);
                ROV[14] = opXML.ModifyNode("num3614", Request.Form["blingminf14"]);
                ROV[15] = opXML.ModifyNode("num3615", Request.Form["blingminf15"]);
                ROV[16] = opXML.ModifyNode("num3616", Request.Form["blingminf16"]);
                ROV[17] = opXML.ModifyNode("num3617", Request.Form["blingminf17"]);
                ROV[18] = opXML.ModifyNode("num3618", Request.Form["blingminf18"]);
                ROV[19] = opXML.ModifyNode("num3619", Request.Form["blingminf19"]);
                ROV[20] = opXML.ModifyNode("num3620", Request.Form["blingminf20"]);
                ROV[21] = opXML.ModifyNode("num3621", Request.Form["blingminf21"]);
                ROV[22] = opXML.ModifyNode("num3622", Request.Form["blingminf22"]);
                ROV[23] = opXML.ModifyNode("num3623", Request.Form["blingminf23"]);
                ROV[24] = opXML.ModifyNode("num3624", Request.Form["blingminf24"]);
                ROV[25] = opXML.ModifyNode("num3625", Request.Form["blingminf25"]);
                ROV[26] = opXML.ModifyNode("num3626", Request.Form["blingminf26"]);
                ROV[27] = opXML.ModifyNode("num3627", Request.Form["blingminf27"]);
                ROV[28] = opXML.ModifyNode("num3628", Request.Form["blingminf28"]);
                ROV[29] = opXML.ModifyNode("num3629", Request.Form["blingminf29"]);
                ROV[30] = opXML.ModifyNode("num3630", Request.Form["blingminf30"]);
                ROV[31] = opXML.ModifyNode("num3631", Request.Form["blingminf31"]);
                ROV[32] = opXML.ModifyNode("num3632", Request.Form["blingminf32"]);
                ROV[33] = opXML.ModifyNode("num3633", Request.Form["blingminf33"]);
                ROV[34] = opXML.ModifyNode("num3634", Request.Form["blingminf34"]);
                ROV[35] = opXML.ModifyNode("num3635", Request.Form["blingminf35"]);
                ROV[36] = opXML.ModifyNode("num3636", Request.Form["blingminf36"]);
                ROV[37] = opXML.ModifyNode("num3637", Request.Form["blingminf37"]);
                ROV[38] = opXML.ModifyNode("num3638", Request.Form["blingminf38"]);
                ROV[39] = opXML.ModifyNode("num3639", Request.Form["blingminf39"]);
                ROV[40] = opXML.ModifyNode("num3640", Request.Form["blingminf40"]);
                ROV[41] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 42; i++)
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

        //混色灵敏度分量写
        public ActionResult postDataHS()
        {
            //声明设备ID，文件名，查询语句，路径，路径
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            try
            {
                //读取值
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("num3901", Request.Form["hunlingminf1"]);
                ROV[2] = opXML.ModifyNode("num3902", Request.Form["hunlingminf2"]);
                ROV[3] = opXML.ModifyNode("num3903", Request.Form["hunlingminf3"]);
                ROV[4] = opXML.ModifyNode("num3904", Request.Form["hunlingminf4"]);
                ROV[5] = opXML.ModifyNode("num3905", Request.Form["hunlingminf5"]);
                ROV[6] = opXML.ModifyNode("num3906", Request.Form["hunlingminf6"]);
                ROV[7] = opXML.ModifyNode("num3907", Request.Form["hunlingminf7"]);
                ROV[8] = opXML.ModifyNode("num3908", Request.Form["hunlingminf8"]);
                ROV[9] = opXML.ModifyNode("num3909", Request.Form["hunlingminf9"]);
                ROV[10] = opXML.ModifyNode("num3910", Request.Form["hunlingminf10"]);
                ROV[11] = opXML.ModifyNode("num3911", Request.Form["hunlingminf11"]);
                ROV[12] = opXML.ModifyNode("num3912", Request.Form["hunlingminf12"]);
                ROV[13] = opXML.ModifyNode("num3913", Request.Form["hunlingminf13"]);
                ROV[14] = opXML.ModifyNode("num3914", Request.Form["hunlingminf14"]);
                ROV[15] = opXML.ModifyNode("num3915", Request.Form["hunlingminf15"]);
                ROV[16] = opXML.ModifyNode("num3916", Request.Form["hunlingminf16"]);
                ROV[17] = opXML.ModifyNode("num3917", Request.Form["hunlingminf17"]);
                ROV[18] = opXML.ModifyNode("num3918", Request.Form["hunlingminf18"]);
                ROV[19] = opXML.ModifyNode("num3919", Request.Form["hunlingminf19"]);
                ROV[20] = opXML.ModifyNode("num3920", Request.Form["hunlingminf20"]);
                ROV[21] = opXML.ModifyNode("num3921", Request.Form["hunlingminf21"]);
                ROV[22] = opXML.ModifyNode("num3922", Request.Form["hunlingminf22"]);
                ROV[23] = opXML.ModifyNode("num3923", Request.Form["hunlingminf23"]);
                ROV[24] = opXML.ModifyNode("num3924", Request.Form["hunlingminf24"]);
                ROV[25] = opXML.ModifyNode("num3925", Request.Form["hunlingminf25"]);
                ROV[26] = opXML.ModifyNode("num3926", Request.Form["hunlingminf26"]);
                ROV[27] = opXML.ModifyNode("num3927", Request.Form["hunlingminf27"]);
                ROV[28] = opXML.ModifyNode("num3928", Request.Form["hunlingminf28"]);
                ROV[29] = opXML.ModifyNode("num3929", Request.Form["hunlingminf29"]);
                ROV[30] = opXML.ModifyNode("num3930", Request.Form["hunlingminf30"]);
                ROV[31] = opXML.ModifyNode("num3931", Request.Form["hunlingminf31"]);
                ROV[32] = opXML.ModifyNode("num3932", Request.Form["hunlingminf32"]);
                ROV[33] = opXML.ModifyNode("num3933", Request.Form["hunlingminf33"]);
                ROV[34] = opXML.ModifyNode("num3934", Request.Form["hunlingminf34"]);
                ROV[35] = opXML.ModifyNode("num3935", Request.Form["hunlingminf35"]);
                ROV[36] = opXML.ModifyNode("num3936", Request.Form["hunlingminf36"]);
                ROV[37] = opXML.ModifyNode("num3937", Request.Form["hunlingminf37"]);
                ROV[38] = opXML.ModifyNode("num3938", Request.Form["hunlingminf38"]);
                ROV[39] = opXML.ModifyNode("num3939", Request.Form["hunlingminf39"]);
                ROV[40] = opXML.ModifyNode("num3940", Request.Form["hunlingminf40"]);
                ROV[41] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 42; i++)
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
