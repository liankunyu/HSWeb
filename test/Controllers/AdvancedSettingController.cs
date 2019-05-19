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
    public class AdvancedSettingController : Controller
    {
        // GET: AdvancedSetting
        public ActionResult AdvancedSetting()
        {
            return View();
        }
        public ActionResult Backdrop()
        {
            return View();
        }
        public ActionResult VGASet()
        {
            return View();
        }
        public ActionResult TypeSelectionSet()
        {
            return View();
        }
        public ActionResult TypeSelectionSensitivity()
        {
            return View();
        }
        public ActionResult AreaFine()
        {
            return View();
        }
        public ActionResult DelaySet()
        {
            return View();
        }
        public ActionResult RGainSet()
        {
            return View();
        }
        public ActionResult GGainSet()
        {
            return View();
        }
        public ActionResult BGainSet()
        {
            return View();
        }
        public ActionResult CollectPictureSet()
        {
            return View();
        }
        public ActionResult TranslationSet()
        {
            return View();
        }
        public ActionResult CameraDivision()
        {
            return View();
        }
        public ActionResult GrayIgnore()
        {
            return View();
        }
        public ActionResult CommState()
        {
            return View();
        }
        public ActionResult ChangeDate()
        {
            return View();
        }

        //背景板读
        public ActionResult SendDataBJB()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] beijing = new string[10];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            beijing[1] = opXML.QueryNodeText("num0001");
            beijing[2] = opXML.QueryNodeText("num0002");
            beijing[3] = opXML.QueryNodeText("num0003");
            beijing[4] = opXML.QueryNodeText("num0004");

            json = "{\"beijing1\":\"" + beijing[1] + "\","
                          + "\"beijing2\":\"" + beijing[2] + "\","
                          + "\"beijing3\":\"" + beijing[3] + "\","
                          + "\"beijing4\":\"" + beijing[4] + "\"}";
            return Content(json);

        }
        //背景板写
        public ActionResult postDataBJB()
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
                ROV[1] = opXML.ModifyNode("num0001", Request.Form["beijing1"]);
                ROV[2] = opXML.ModifyNode("num0002", Request.Form["beijing2"]);
                ROV[3] = opXML.ModifyNode("num0003", Request.Form["beijing3"]);
                ROV[4] = opXML.ModifyNode("num0004", Request.Form["beijing4"]);
                ROV[5] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 6; i++)
                {
                    if (ROV[i]==false)
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
        //VGA设定读
        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] vga = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            vga[21] = opXML.QueryNodeText("num1821");
            vga[22] = opXML.QueryNodeText("num1822");
            vga[23] = opXML.QueryNodeText("num1823");
            vga[24] = opXML.QueryNodeText("num1824");
            vga[25] = opXML.QueryNodeText("num1825");
            vga[26] = opXML.QueryNodeText("num1826");
            vga[27] = opXML.QueryNodeText("num1827");
            vga[28] = opXML.QueryNodeText("num1828");
            vga[29] = opXML.QueryNodeText("num1829");
            vga[30] = opXML.QueryNodeText("num1830");
            vga[31] = opXML.QueryNodeText("num1831");
            vga[32] = opXML.QueryNodeText("num1832");
            vga[33] = opXML.QueryNodeText("num1833");
            vga[34] = opXML.QueryNodeText("num1834");
            vga[35] = opXML.QueryNodeText("num1835");
            vga[36] = opXML.QueryNodeText("num1836");
            vga[37] = opXML.QueryNodeText("num1837");
            vga[38] = opXML.QueryNodeText("num1838");
            vga[39] = opXML.QueryNodeText("num1839");
            vga[40] = opXML.QueryNodeText("num1840");

            vga[1] = opXML.QueryNodeText("num1801");
            vga[2] = opXML.QueryNodeText("num1802");
            vga[3] = opXML.QueryNodeText("num1803");
            vga[4] = opXML.QueryNodeText("num1804");

            json = "{\"vga1\":\"" + vga[21] + "\","
                          + "\"vga2\":\"" + vga[22] + "\","
                          + "\"vga3\":\"" + vga[23] + "\","
                          + "\"vga4\":\"" + vga[24] + "\","
                          + "\"vga5\":\"" + vga[25] + "\","
                          + "\"vga6\":\"" + vga[26] + "\","
                          + "\"vga7\":\"" + vga[27] + "\","
                          + "\"vga8\":\"" + vga[28] + "\","
                          + "\"vga9\":\"" + vga[29] + "\","
                          + "\"vga10\":\"" + vga[30] + "\","
                          + "\"vga11\":\"" + vga[31] + "\","
                          + "\"vga12\":\"" + vga[32] + "\","
                          + "\"vga13\":\"" + vga[33] + "\","
                          + "\"vga14\":\"" + vga[34] + "\","
                          + "\"vga15\":\"" + vga[35] + "\","
                          + "\"vga16\":\"" + vga[36] + "\","
                          + "\"vga17\":\"" + vga[37] + "\","
                          + "\"vga18\":\"" + vga[38] + "\","
                          + "\"vga19\":\"" + vga[39] + "\","
                          + "\"vga20\":\"" + vga[40] + "\","
                          + "\"vga21\":\"" + vga[1] + "\","
                          + "\"vga22\":\"" + vga[2] + "\","
                          + "\"vga23\":\"" + vga[3] + "\","
                          + "\"vga24\":\"" + vga[4] + "\"}";
            return Content(json);
        }
        //VGA设定写
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
                ROV[1] = opXML.ModifyNode("num1821", Request.Form["vga1"]);
                ROV[2] = opXML.ModifyNode("num1822", Request.Form["vga2"]);
                ROV[3] = opXML.ModifyNode("num1823", Request.Form["vga3"]);
                ROV[4] = opXML.ModifyNode("num1824", Request.Form["vga4"]);
                ROV[5] = opXML.ModifyNode("num1825", Request.Form["vga5"]);
                ROV[6] = opXML.ModifyNode("num1826", Request.Form["vga6"]);
                ROV[7] = opXML.ModifyNode("num1827", Request.Form["vga7"]);
                ROV[8] = opXML.ModifyNode("num1828", Request.Form["vga8"]);
                ROV[9] = opXML.ModifyNode("num1829", Request.Form["vga9"]);
                ROV[10] = opXML.ModifyNode("num1830", Request.Form["vga10"]);
                ROV[11] = opXML.ModifyNode("num1831", Request.Form["vga11"]);
                ROV[12] = opXML.ModifyNode("num1832", Request.Form["vga12"]);
                ROV[13] = opXML.ModifyNode("num1833", Request.Form["vga13"]);
                ROV[14] = opXML.ModifyNode("num1834", Request.Form["vga14"]);
                ROV[15] = opXML.ModifyNode("num1835", Request.Form["vga15"]);
                ROV[16] = opXML.ModifyNode("num1836", Request.Form["vga16"]);
                ROV[17] = opXML.ModifyNode("num1837", Request.Form["vga17"]);
                ROV[18] = opXML.ModifyNode("num1838", Request.Form["vga18"]);
                ROV[19] = opXML.ModifyNode("num1839", Request.Form["vga19"]);
                ROV[20] = opXML.ModifyNode("num1840", Request.Form["vga20"]);

                ROV[21] = opXML.ModifyNode("num1801", Request.Form["vga21"]);
                ROV[22] = opXML.ModifyNode("num1802", Request.Form["vga22"]);
                ROV[23] = opXML.ModifyNode("num1803", Request.Form["vga23"]);
                ROV[24] = opXML.ModifyNode("num1804", Request.Form["vga24"]);
                ROV[25] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 26; i++)
                {
                    if (ROV[i]==false)
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
        //型选设置读
        public ActionResult SendDataXXSZ()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] xxsz = new string[10];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            xxsz[1] = opXML.QueryNodeText("num3101");
            xxsz[2] = opXML.QueryNodeText("num3102");
            xxsz[3] = opXML.QueryNodeText("num3103");
            xxsz[4] = opXML.QueryNodeText("num3104");

            json = "{\"xxsz1\":\"" + xxsz[1] + "\","
                          + "\"xxsz2\":\"" + xxsz[2] + "\","
                          + "\"xxsz3\":\"" + xxsz[3] + "\","
                          + "\"xxsz4\":\"" + xxsz[4] + "\"}";
            return Content(json);
        }

        //型选设置写
        public ActionResult postDataXXSZ()
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
                ROV[1] = opXML.ModifyNode("num3101", Request.Form["xxsz1"]);
                ROV[2] = opXML.ModifyNode("num3102", Request.Form["xxsz2"]);
                ROV[3] = opXML.ModifyNode("num3103", Request.Form["xxsz3"]);
                ROV[4] = opXML.ModifyNode("num3104", Request.Form["xxsz4"]);
                ROV[5] = opXML.saveFile();        
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 6; i++)
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
        //型选灵敏度读
        public ActionResult SendDataXXLMD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] xxlmd = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            xxlmd[1] = opXML.QueryNodeText("num3001");
            xxlmd[2] = opXML.QueryNodeText("num3002");
            xxlmd[3] = opXML.QueryNodeText("num3003");
            xxlmd[4] = opXML.QueryNodeText("num3004");
            xxlmd[5] = opXML.QueryNodeText("num3005");
            xxlmd[6] = opXML.QueryNodeText("num3006");
            xxlmd[7] = opXML.QueryNodeText("num3007");
            xxlmd[8] = opXML.QueryNodeText("num3008");
            xxlmd[9] = opXML.QueryNodeText("num3009");
            xxlmd[10] = opXML.QueryNodeText("num3010");
            xxlmd[11] = opXML.QueryNodeText("num3011");
            xxlmd[12] = opXML.QueryNodeText("num3012");
            xxlmd[13] = opXML.QueryNodeText("num3013");
            xxlmd[14] = opXML.QueryNodeText("num3014");
            xxlmd[15] = opXML.QueryNodeText("num3015");
            xxlmd[16] = opXML.QueryNodeText("num3016");
            xxlmd[17] = opXML.QueryNodeText("num3017");
            xxlmd[18] = opXML.QueryNodeText("num3018");
            xxlmd[19] = opXML.QueryNodeText("num3019");
            xxlmd[20] = opXML.QueryNodeText("num3020");

            json = "{\"xxlmd1\":\"" + xxlmd[1] + "\","
                          + "\"xxlmd2\":\"" + xxlmd[2] + "\","
                          + "\"xxlmd3\":\"" + xxlmd[3] + "\","
                          + "\"xxlmd4\":\"" + xxlmd[4] + "\","
                          + "\"xxlmd5\":\"" + xxlmd[5] + "\","
                          + "\"xxlmd6\":\"" + xxlmd[6] + "\","
                          + "\"xxlmd7\":\"" + xxlmd[7] + "\","
                          + "\"xxlmd8\":\"" + xxlmd[8] + "\","
                          + "\"xxlmd9\":\"" + xxlmd[9] + "\","
                          + "\"xxlmd10\":\"" + xxlmd[10] + "\","
                          + "\"xxlmd11\":\"" + xxlmd[11] + "\","
                          + "\"xxlmd12\":\"" + xxlmd[12] + "\","
                          + "\"xxlmd13\":\"" + xxlmd[13] + "\","
                          + "\"xxlmd14\":\"" + xxlmd[14] + "\","
                          + "\"xxlmd15\":\"" + xxlmd[15] + "\","
                          + "\"xxlmd16\":\"" + xxlmd[16] + "\","
                          + "\"xxlmd17\":\"" + xxlmd[17] + "\","
                          + "\"xxlmd18\":\"" + xxlmd[18] + "\","
                          + "\"xxlmd19\":\"" + xxlmd[19] + "\","
                          + "\"xxlmd20\":\"" + xxlmd[20] + "\"}";
            return Content(json);
        }

        //型选灵敏度写
        public ActionResult postDataXXLMD()
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
                ROV[1] = opXML.ModifyNode("num3001", Request.Form["xxlmd1"]);
                ROV[2] = opXML.ModifyNode("num3002", Request.Form["xxlmd2"]);
                ROV[3] = opXML.ModifyNode("num3003", Request.Form["xxlmd3"]);
                ROV[4] = opXML.ModifyNode("num3004", Request.Form["xxlmd4"]);
                ROV[5] = opXML.ModifyNode("num3005", Request.Form["xxlmd5"]);
                ROV[6] = opXML.ModifyNode("num3006", Request.Form["xxlmd6"]);
                ROV[7] = opXML.ModifyNode("num3007", Request.Form["xxlmd7"]);
                ROV[8] = opXML.ModifyNode("num3008", Request.Form["xxlmd8"]);
                ROV[9] = opXML.ModifyNode("num3009", Request.Form["xxlmd9"]);
                ROV[10] = opXML.ModifyNode("num3010", Request.Form["xxlmd10"]);
                ROV[11] = opXML.ModifyNode("num3011", Request.Form["xxlmd11"]);
                ROV[12] = opXML.ModifyNode("num3012", Request.Form["xxlmd12"]);
                ROV[13] = opXML.ModifyNode("num3013", Request.Form["xxlmd13"]);
                ROV[14] = opXML.ModifyNode("num3014", Request.Form["xxlmd14"]);
                ROV[15] = opXML.ModifyNode("num3015", Request.Form["xxlmd15"]);
                ROV[16] = opXML.ModifyNode("num3016", Request.Form["xxlmd16"]);
                ROV[17] = opXML.ModifyNode("num3017", Request.Form["xxlmd17"]);
                ROV[18] = opXML.ModifyNode("num3018", Request.Form["xxlmd18"]);
                ROV[19] = opXML.ModifyNode("num3019", Request.Form["xxlmd19"]);
                ROV[20] = opXML.ModifyNode("num3020", Request.Form["xxlmd20"]);
                ROV[21] = opXML.saveFile(); 
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //面积微调读
        public ActionResult SendDataMJWT()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] mjwt = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            mjwt[1] = opXML.QueryNodeText("num2501");
            mjwt[2] = opXML.QueryNodeText("num2502");
            mjwt[3] = opXML.QueryNodeText("num2503");
            mjwt[4] = opXML.QueryNodeText("num2504");
            mjwt[5] = opXML.QueryNodeText("num2505");
            mjwt[6] = opXML.QueryNodeText("num2506");
            mjwt[7] = opXML.QueryNodeText("num2507");
            mjwt[8] = opXML.QueryNodeText("num2508");
            mjwt[9] = opXML.QueryNodeText("num2509");
            mjwt[10] = opXML.QueryNodeText("num2510");
            mjwt[11] = opXML.QueryNodeText("num2511");
            mjwt[12] = opXML.QueryNodeText("num2512");
            mjwt[13] = opXML.QueryNodeText("num2513");
            mjwt[14] = opXML.QueryNodeText("num2514");
            mjwt[15] = opXML.QueryNodeText("num2515");
            mjwt[16] = opXML.QueryNodeText("num2516");
            mjwt[17] = opXML.QueryNodeText("num2517");
            mjwt[18] = opXML.QueryNodeText("num2518");
            mjwt[19] = opXML.QueryNodeText("num2519");
            mjwt[20] = opXML.QueryNodeText("num2520");

            json = "{\"mjwt1\":\"" + mjwt[1] + "\","
                          + "\"mjwt2\":\"" + mjwt[2] + "\","
                          + "\"mjwt3\":\"" + mjwt[3] + "\","
                          + "\"mjwt4\":\"" + mjwt[4] + "\","
                          + "\"mjwt5\":\"" + mjwt[5] + "\","
                          + "\"mjwt6\":\"" + mjwt[6] + "\","
                          + "\"mjwt7\":\"" + mjwt[7] + "\","
                          + "\"mjwt8\":\"" + mjwt[8] + "\","
                          + "\"mjwt9\":\"" + mjwt[9] + "\","
                          + "\"mjwt10\":\"" + mjwt[10] + "\","
                          + "\"mjwt11\":\"" + mjwt[11] + "\","
                          + "\"mjwt12\":\"" + mjwt[12] + "\","
                          + "\"mjwt13\":\"" + mjwt[13] + "\","
                          + "\"mjwt14\":\"" + mjwt[14] + "\","
                          + "\"mjwt15\":\"" + mjwt[15] + "\","
                          + "\"mjwt16\":\"" + mjwt[16] + "\","
                          + "\"mjwt17\":\"" + mjwt[17] + "\","
                          + "\"mjwt18\":\"" + mjwt[18] + "\","
                          + "\"mjwt19\":\"" + mjwt[19] + "\","
                          + "\"mjwt20\":\"" + mjwt[20] + "\"}";
            return Content(json);
        }
        //面积微调写
        public ActionResult postDataMJWT()
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
                ROV[1] = opXML.ModifyNode("num2501", Request.Form["mjwt1"]);
                ROV[2] = opXML.ModifyNode("num2502", Request.Form["mjwt2"]);
                ROV[3] = opXML.ModifyNode("num2503", Request.Form["mjwt3"]);
                ROV[4] = opXML.ModifyNode("num2504", Request.Form["mjwt4"]);
                ROV[5] = opXML.ModifyNode("num2505", Request.Form["mjwt5"]);
                ROV[6] = opXML.ModifyNode("num2506", Request.Form["mjwt6"]);
                ROV[7] = opXML.ModifyNode("num2507", Request.Form["mjwt7"]);
                ROV[8] = opXML.ModifyNode("num2508", Request.Form["mjwt8"]);
                ROV[9] = opXML.ModifyNode("num2509", Request.Form["mjwt9"]);
                ROV[10] = opXML.ModifyNode("num2510", Request.Form["mjwt10"]);
                ROV[11] = opXML.ModifyNode("num2511", Request.Form["mjwt11"]);
                ROV[12] = opXML.ModifyNode("num2512", Request.Form["mjwt12"]);
                ROV[13] = opXML.ModifyNode("num2513", Request.Form["mjwt13"]);
                ROV[14] = opXML.ModifyNode("num2514", Request.Form["mjwt14"]);
                ROV[15] = opXML.ModifyNode("num2515", Request.Form["mjwt15"]);
                ROV[16] = opXML.ModifyNode("num2516", Request.Form["mjwt16"]);
                ROV[17] = opXML.ModifyNode("num2517", Request.Form["mjwt17"]);
                ROV[18] = opXML.ModifyNode("num2518", Request.Form["mjwt18"]);
                ROV[19] = opXML.ModifyNode("num2519", Request.Form["mjwt19"]);
                ROV[20] = opXML.ModifyNode("num2520", Request.Form["mjwt20"]);
                ROV[21] = opXML.saveFile();     
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //R增益设定读
        public ActionResult SendDataRZYSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] rzysd = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            rzysd[1] = opXML.QueryNodeText("num1601");
            rzysd[2] = opXML.QueryNodeText("num1602");
            rzysd[3] = opXML.QueryNodeText("num1603");
            rzysd[4] = opXML.QueryNodeText("num1604");
            rzysd[5] = opXML.QueryNodeText("num1605");
            rzysd[6] = opXML.QueryNodeText("num1606");
            rzysd[7] = opXML.QueryNodeText("num1607");
            rzysd[8] = opXML.QueryNodeText("num1608");
            rzysd[9] = opXML.QueryNodeText("num1609");
            rzysd[10] = opXML.QueryNodeText("num1610");
            rzysd[11] = opXML.QueryNodeText("num1611");
            rzysd[12] = opXML.QueryNodeText("num1612");
            rzysd[13] = opXML.QueryNodeText("num1613");
            rzysd[14] = opXML.QueryNodeText("num1614");
            rzysd[15] = opXML.QueryNodeText("num1615");
            rzysd[16] = opXML.QueryNodeText("num1616");
            rzysd[17] = opXML.QueryNodeText("num1617");
            rzysd[18] = opXML.QueryNodeText("num1618");
            rzysd[19] = opXML.QueryNodeText("num1619");
            rzysd[20] = opXML.QueryNodeText("num1620");

            json = "{\"rzysd1\":\"" + rzysd[1] + "\","
                          + "\"rzysd2\":\"" + rzysd[2] + "\","
                          + "\"rzysd3\":\"" + rzysd[3] + "\","
                          + "\"rzysd4\":\"" + rzysd[4] + "\","
                          + "\"rzysd5\":\"" + rzysd[5] + "\","
                          + "\"rzysd6\":\"" + rzysd[6] + "\","
                          + "\"rzysd7\":\"" + rzysd[7] + "\","
                          + "\"rzysd8\":\"" + rzysd[8] + "\","
                          + "\"rzysd9\":\"" + rzysd[9] + "\","
                          + "\"rzysd10\":\"" + rzysd[10] + "\","
                          + "\"rzysd11\":\"" + rzysd[11] + "\","
                          + "\"rzysd12\":\"" + rzysd[12] + "\","
                          + "\"rzysd13\":\"" + rzysd[13] + "\","
                          + "\"rzysd14\":\"" + rzysd[14] + "\","
                          + "\"rzysd15\":\"" + rzysd[15] + "\","
                          + "\"rzysd16\":\"" + rzysd[16] + "\","
                          + "\"rzysd17\":\"" + rzysd[17] + "\","
                          + "\"rzysd18\":\"" + rzysd[18] + "\","
                          + "\"rzysd19\":\"" + rzysd[19] + "\","
                          + "\"rzysd20\":\"" + rzysd[20] + "\"}";
            return Content(json);
        }
        //R增益设定写
        public ActionResult postDataRZYSD()
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
                ROV[1] = opXML.ModifyNode("num1601", Request.Form["rzysd1"]);
                ROV[2] = opXML.ModifyNode("num1602", Request.Form["rzysd2"]);
                ROV[3] = opXML.ModifyNode("num1603", Request.Form["rzysd3"]);
                ROV[4] = opXML.ModifyNode("num1604", Request.Form["rzysd4"]);
                ROV[5] = opXML.ModifyNode("num1605", Request.Form["rzysd5"]);
                ROV[6] = opXML.ModifyNode("num1606", Request.Form["rzysd6"]);
                ROV[7] = opXML.ModifyNode("num1607", Request.Form["rzysd7"]);
                ROV[8] = opXML.ModifyNode("num1608", Request.Form["rzysd8"]);
                ROV[9] = opXML.ModifyNode("num1609", Request.Form["rzysd9"]);
                ROV[10] = opXML.ModifyNode("num1610", Request.Form["rzysd10"]);
                ROV[11] = opXML.ModifyNode("num1611", Request.Form["rzysd11"]);
                ROV[12] = opXML.ModifyNode("num1612", Request.Form["rzysd12"]);
                ROV[13] = opXML.ModifyNode("num1613", Request.Form["rzysd13"]);
                ROV[14] = opXML.ModifyNode("num1614", Request.Form["rzysd14"]);
                ROV[15] = opXML.ModifyNode("num1615", Request.Form["rzysd15"]);
                ROV[16] = opXML.ModifyNode("num1616", Request.Form["rzysd16"]);
                ROV[17] = opXML.ModifyNode("num1617", Request.Form["rzysd17"]);
                ROV[18] = opXML.ModifyNode("num1618", Request.Form["rzysd18"]);
                ROV[19] = opXML.ModifyNode("num1619", Request.Form["rzysd19"]);
                ROV[20] = opXML.ModifyNode("num1620", Request.Form["rzysd20"]);
                ROV[21] = opXML.saveFile();     
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //G增益设定读
        public ActionResult SendDataGZYSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] gzysd = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            gzysd[1] = opXML.QueryNodeText("num0801");
            gzysd[2] = opXML.QueryNodeText("num0802");
            gzysd[3] = opXML.QueryNodeText("num0803");
            gzysd[4] = opXML.QueryNodeText("num0804");
            gzysd[5] = opXML.QueryNodeText("num0805");
            gzysd[6] = opXML.QueryNodeText("num0806");
            gzysd[7] = opXML.QueryNodeText("num0807");
            gzysd[8] = opXML.QueryNodeText("num0808");
            gzysd[9] = opXML.QueryNodeText("num0809");
            gzysd[10] = opXML.QueryNodeText("num0810");
            gzysd[11] = opXML.QueryNodeText("num0811");
            gzysd[12] = opXML.QueryNodeText("num0812");
            gzysd[13] = opXML.QueryNodeText("num0813");
            gzysd[14] = opXML.QueryNodeText("num0814");
            gzysd[15] = opXML.QueryNodeText("num0815");
            gzysd[16] = opXML.QueryNodeText("num0816");
            gzysd[17] = opXML.QueryNodeText("num0817");
            gzysd[18] = opXML.QueryNodeText("num0818");
            gzysd[19] = opXML.QueryNodeText("num0819");
            gzysd[20] = opXML.QueryNodeText("num0820");

            json = "{\"gzysd1\":\"" + gzysd[1] + "\","
                          + "\"gzysd2\":\"" + gzysd[2] + "\","
                          + "\"gzysd3\":\"" + gzysd[3] + "\","
                          + "\"gzysd4\":\"" + gzysd[4] + "\","
                          + "\"gzysd5\":\"" + gzysd[5] + "\","
                          + "\"gzysd6\":\"" + gzysd[6] + "\","
                          + "\"gzysd7\":\"" + gzysd[7] + "\","
                          + "\"gzysd8\":\"" + gzysd[8] + "\","
                          + "\"gzysd9\":\"" + gzysd[9] + "\","
                          + "\"gzysd10\":\"" + gzysd[10] + "\","
                          + "\"gzysd11\":\"" + gzysd[11] + "\","
                          + "\"gzysd12\":\"" + gzysd[12] + "\","
                          + "\"gzysd13\":\"" + gzysd[13] + "\","
                          + "\"gzysd14\":\"" + gzysd[14] + "\","
                          + "\"gzysd15\":\"" + gzysd[15] + "\","
                          + "\"gzysd16\":\"" + gzysd[16] + "\","
                          + "\"gzysd17\":\"" + gzysd[17] + "\","
                          + "\"gzysd18\":\"" + gzysd[18] + "\","
                          + "\"gzysd19\":\"" + gzysd[19] + "\","
                          + "\"gzysd20\":\"" + gzysd[20] + "\"}";
            return Content(json);
        }
        //G增益设定写
        public ActionResult postDataGZYSD()
        {          //声明设备ID，文件名，查询语句，路径，路径，JSON
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
                ROV[1] = opXML.ModifyNode("num0801", Request.Form["gzysd1"]);
                ROV[2] = opXML.ModifyNode("num0802", Request.Form["gzysd2"]);
                ROV[3] = opXML.ModifyNode("num0803", Request.Form["gzysd3"]);
                ROV[4] = opXML.ModifyNode("num0804", Request.Form["gzysd4"]);
                ROV[5] = opXML.ModifyNode("num0805", Request.Form["gzysd5"]);
                ROV[6] = opXML.ModifyNode("num0806", Request.Form["gzysd6"]);
                ROV[7] = opXML.ModifyNode("num0807", Request.Form["gzysd7"]);
                ROV[8] = opXML.ModifyNode("num0808", Request.Form["gzysd8"]);
                ROV[9] = opXML.ModifyNode("num0809", Request.Form["gzysd9"]);
                ROV[10] = opXML.ModifyNode("num0810", Request.Form["gzysd10"]);
                ROV[11] = opXML.ModifyNode("num0811", Request.Form["gzysd11"]);
                ROV[12] = opXML.ModifyNode("num0812", Request.Form["gzysd12"]);
                ROV[13] = opXML.ModifyNode("num0813", Request.Form["gzysd13"]);
                ROV[14] = opXML.ModifyNode("num0814", Request.Form["gzysd14"]);
                ROV[15] = opXML.ModifyNode("num0815", Request.Form["gzysd15"]);
                ROV[16] = opXML.ModifyNode("num0816", Request.Form["gzysd16"]);
                ROV[17] = opXML.ModifyNode("num0817", Request.Form["gzysd17"]);
                ROV[18] = opXML.ModifyNode("num0818", Request.Form["gzysd18"]);
                ROV[19] = opXML.ModifyNode("num0819", Request.Form["gzysd19"]);
                ROV[20] = opXML.ModifyNode("num0820", Request.Form["gzysd20"]);
                ROV[21] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //B增益设定读
        public ActionResult SendDataBZYSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] bzysd = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            bzysd[1] = opXML.QueryNodeText("num0301");
            bzysd[2] = opXML.QueryNodeText("num0302");
            bzysd[3] = opXML.QueryNodeText("num0303");
            bzysd[4] = opXML.QueryNodeText("num0304");
            bzysd[5] = opXML.QueryNodeText("num0305");
            bzysd[6] = opXML.QueryNodeText("num0306");
            bzysd[7] = opXML.QueryNodeText("num0307");
            bzysd[8] = opXML.QueryNodeText("num0308");
            bzysd[9] = opXML.QueryNodeText("num0309");
            bzysd[10] = opXML.QueryNodeText("num0310");
            bzysd[11] = opXML.QueryNodeText("num0311");
            bzysd[12] = opXML.QueryNodeText("num0312");
            bzysd[13] = opXML.QueryNodeText("num0313");
            bzysd[14] = opXML.QueryNodeText("num0314");
            bzysd[15] = opXML.QueryNodeText("num0315");
            bzysd[16] = opXML.QueryNodeText("num0316");
            bzysd[17] = opXML.QueryNodeText("num0317");
            bzysd[18] = opXML.QueryNodeText("num0318");
            bzysd[19] = opXML.QueryNodeText("num0319");
            bzysd[20] = opXML.QueryNodeText("num0320");

            json = "{\"bzysd1\":\"" + bzysd[1] + "\","
                          + "\"bzysd2\":\"" + bzysd[2] + "\","
                          + "\"bzysd3\":\"" + bzysd[3] + "\","
                          + "\"bzysd4\":\"" + bzysd[4] + "\","
                          + "\"bzysd5\":\"" + bzysd[5] + "\","
                          + "\"bzysd6\":\"" + bzysd[6] + "\","
                          + "\"bzysd7\":\"" + bzysd[7] + "\","
                          + "\"bzysd8\":\"" + bzysd[8] + "\","
                          + "\"bzysd9\":\"" + bzysd[9] + "\","
                          + "\"bzysd10\":\"" + bzysd[10] + "\","
                          + "\"bzysd11\":\"" + bzysd[11] + "\","
                          + "\"bzysd12\":\"" + bzysd[12] + "\","
                          + "\"bzysd13\":\"" + bzysd[13] + "\","
                          + "\"bzysd14\":\"" + bzysd[14] + "\","
                          + "\"bzysd15\":\"" + bzysd[15] + "\","
                          + "\"bzysd16\":\"" + bzysd[16] + "\","
                          + "\"bzysd17\":\"" + bzysd[17] + "\","
                          + "\"bzysd18\":\"" + bzysd[18] + "\","
                          + "\"bzysd19\":\"" + bzysd[19] + "\","
                          + "\"bzysd20\":\"" + bzysd[20] + "\"}";
            return Content(json);

        }
        //B增益设定写
        public ActionResult postDataBZYSD()
        {           //声明设备ID，文件名，查询语句，路径，路径，JSON
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
                ROV[1] = opXML.ModifyNode("num0301", Request.Form["bzysd1"]);
                ROV[2] = opXML.ModifyNode("num0302", Request.Form["bzysd2"]);
                ROV[3] = opXML.ModifyNode("num0303", Request.Form["bzysd3"]);
                ROV[4] = opXML.ModifyNode("num0304", Request.Form["bzysd4"]);
                ROV[5] = opXML.ModifyNode("num0305", Request.Form["bzysd5"]);
                ROV[6] = opXML.ModifyNode("num0306", Request.Form["bzysd6"]);
                ROV[7] = opXML.ModifyNode("num0307", Request.Form["bzysd7"]);
                ROV[8] = opXML.ModifyNode("num0308", Request.Form["bzysd8"]);
                ROV[9] = opXML.ModifyNode("num0309", Request.Form["bzysd9"]);
                ROV[10] = opXML.ModifyNode("num0310", Request.Form["bzysd10"]);
                ROV[11] = opXML.ModifyNode("num0311", Request.Form["bzysd11"]);
                ROV[12] = opXML.ModifyNode("num0312", Request.Form["bzysd12"]);
                ROV[13] = opXML.ModifyNode("num0313", Request.Form["bzysd13"]);
                ROV[14] = opXML.ModifyNode("num0314", Request.Form["bzysd14"]);
                ROV[15] = opXML.ModifyNode("num0315", Request.Form["bzysd15"]);
                ROV[16] = opXML.ModifyNode("num0316", Request.Form["bzysd16"]);
                ROV[17] = opXML.ModifyNode("num0317", Request.Form["bzysd17"]);
                ROV[18] = opXML.ModifyNode("num0318", Request.Form["bzysd18"]);
                ROV[19] = opXML.ModifyNode("num0319", Request.Form["bzysd19"]);
                ROV[20] = opXML.ModifyNode("num0320", Request.Form["bzysd20"]);
                ROV[21] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //采图设置读
        public ActionResult SendDataCTSZ()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] ctsz = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            ctsz[1] = opXML.QueryNodeText("num0401");
            ctsz[2] = opXML.QueryNodeText("num0402");
            ctsz[3] = opXML.QueryNodeText("num0403");
            ctsz[4] = opXML.QueryNodeText("num0404");
            ctsz[5] = opXML.QueryNodeText("num0405");
            ctsz[6] = opXML.QueryNodeText("num0406");
            ctsz[7] = opXML.QueryNodeText("num0407");
            ctsz[8] = opXML.QueryNodeText("num0408");
            ctsz[9] = opXML.QueryNodeText("num0409");
            ctsz[10] = opXML.QueryNodeText("num0410");
            ctsz[11] = opXML.QueryNodeText("num0411");
            ctsz[12] = opXML.QueryNodeText("num0412");
            ctsz[13] = opXML.QueryNodeText("num0413");
            ctsz[14] = opXML.QueryNodeText("num0414");
            ctsz[15] = opXML.QueryNodeText("num0415");
            ctsz[16] = opXML.QueryNodeText("num0416");
            ctsz[17] = opXML.QueryNodeText("num0417");
            ctsz[18] = opXML.QueryNodeText("num0418");
            ctsz[19] = opXML.QueryNodeText("num0419");
            ctsz[20] = opXML.QueryNodeText("num0420");
            ctsz[21] = opXML.QueryNodeText("num0421");
            ctsz[22] = opXML.QueryNodeText("num0422");
            ctsz[23] = opXML.QueryNodeText("num0423");
            ctsz[24] = opXML.QueryNodeText("num0424");
            ctsz[25] = opXML.QueryNodeText("num0425");

            json = "{\"ctsz1\":\"" + ctsz[1] + "\","
                          + "\"ctsz2\":\"" + ctsz[2] + "\","
                          + "\"ctsz3\":\"" + ctsz[3] + "\","
                          + "\"ctsz4\":\"" + ctsz[4] + "\","
                          + "\"ctsz5\":\"" + ctsz[5] + "\","
                          + "\"ctsz6\":\"" + ctsz[6] + "\","
                          + "\"ctsz7\":\"" + ctsz[7] + "\","
                          + "\"ctsz8\":\"" + ctsz[8] + "\","
                          + "\"ctsz9\":\"" + ctsz[9] + "\","
                          + "\"ctsz10\":\"" + ctsz[10] + "\","
                          + "\"ctsz11\":\"" + ctsz[11] + "\","
                          + "\"ctsz12\":\"" + ctsz[12] + "\","
                          + "\"ctsz13\":\"" + ctsz[13] + "\","
                          + "\"ctsz14\":\"" + ctsz[14] + "\","
                          + "\"ctsz15\":\"" + ctsz[15] + "\","
                          + "\"ctsz16\":\"" + ctsz[16] + "\","
                          + "\"ctsz17\":\"" + ctsz[17] + "\","
                          + "\"ctsz18\":\"" + ctsz[18] + "\","
                          + "\"ctsz19\":\"" + ctsz[19] + "\","
                          + "\"ctsz20\":\"" + ctsz[20] + "\","
                          + "\"ctsz21\":\"" + ctsz[21] + "\","
                          + "\"ctsz22\":\"" + ctsz[22] + "\","
                          + "\"ctsz23\":\"" + ctsz[23] + "\","
                          + "\"ctsz24\":\"" + ctsz[24] + "\","
                          + "\"ctsz25\":\"" + ctsz[25] + "\"}";
            return Content(json);
        }
        //采图设置写
        public ActionResult postDataCTSZ()
        {         //声明设备ID，文件名，查询语句，路径，路径，JSON
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
                ROV[1] = opXML.ModifyNode("num0401", Request.Form["ctsz1"]);
                ROV[2] = opXML.ModifyNode("num0402", Request.Form["ctsz2"]);
                ROV[3] = opXML.ModifyNode("num0403", Request.Form["ctsz3"]);
                ROV[4] = opXML.ModifyNode("num0404", Request.Form["ctsz4"]);
                ROV[5] = opXML.ModifyNode("num0405", Request.Form["ctsz5"]);
                ROV[6] = opXML.ModifyNode("num0406", Request.Form["ctsz6"]);
                ROV[7] = opXML.ModifyNode("num0407", Request.Form["ctsz7"]);
                ROV[8] = opXML.ModifyNode("num0408", Request.Form["ctsz8"]);
                ROV[9] = opXML.ModifyNode("num0409", Request.Form["ctsz9"]);
                ROV[10] = opXML.ModifyNode("num0410", Request.Form["ctsz10"]);
                ROV[11] = opXML.ModifyNode("num0411", Request.Form["ctsz11"]);
                ROV[12] = opXML.ModifyNode("num0412", Request.Form["ctsz12"]);
                ROV[13] = opXML.ModifyNode("num0413", Request.Form["ctsz13"]);
                ROV[14] = opXML.ModifyNode("num0414", Request.Form["ctsz14"]);
                ROV[15] = opXML.ModifyNode("num0415", Request.Form["ctsz15"]);
                ROV[16] = opXML.ModifyNode("num0416", Request.Form["ctsz16"]);
                ROV[17] = opXML.ModifyNode("num0417", Request.Form["ctsz17"]);
                ROV[18] = opXML.ModifyNode("num0418", Request.Form["ctsz18"]);
                ROV[19] = opXML.ModifyNode("num0419", Request.Form["ctsz19"]);
                ROV[20] = opXML.ModifyNode("num0420", Request.Form["ctsz20"]);
                ROV[21] = opXML.ModifyNode("num0421", Request.Form["ctsz21"]);
                ROV[22] = opXML.ModifyNode("num0422", Request.Form["ctsz22"]);
                ROV[23] = opXML.ModifyNode("num0423", Request.Form["ctsz23"]);
                ROV[24] = opXML.ModifyNode("num0424", Request.Form["ctsz24"]);
                ROV[25] = opXML.ModifyNode("num0425", Request.Form["ctsz25"]);
                ROV[26] = opXML.saveFile();  
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 27; i++)
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
        //平移设定读
        public ActionResult SendDataPYSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] pysd = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            pysd[1] = opXML.QueryNodeText("num1201");
            pysd[2] = opXML.QueryNodeText("num1202");
            pysd[3] = opXML.QueryNodeText("num1203");
            pysd[4] = opXML.QueryNodeText("num1204");
            pysd[5] = opXML.QueryNodeText("num1205");
            pysd[6] = opXML.QueryNodeText("num1206");
            pysd[7] = opXML.QueryNodeText("num1207");
            pysd[8] = opXML.QueryNodeText("num1208");
            pysd[9] = opXML.QueryNodeText("num1209");
            pysd[10] = opXML.QueryNodeText("num1210");
            pysd[11] = opXML.QueryNodeText("num1211");
            pysd[12] = opXML.QueryNodeText("num1212");
            pysd[13] = opXML.QueryNodeText("num1213");
            pysd[14] = opXML.QueryNodeText("num1214");
            pysd[15] = opXML.QueryNodeText("num1215");
            pysd[16] = opXML.QueryNodeText("num1216");
            pysd[17] = opXML.QueryNodeText("num1217");
            pysd[18] = opXML.QueryNodeText("num1218");
            pysd[19] = opXML.QueryNodeText("num1219");
            pysd[20] = opXML.QueryNodeText("num1220");

            json = "{\"pysd1\":\"" + pysd[1] + "\","
                          + "\"pysd2\":\"" + pysd[2] + "\","
                          + "\"pysd3\":\"" + pysd[3] + "\","
                          + "\"pysd4\":\"" + pysd[4] + "\","
                          + "\"pysd5\":\"" + pysd[5] + "\","
                          + "\"pysd6\":\"" + pysd[6] + "\","
                          + "\"pysd7\":\"" + pysd[7] + "\","
                          + "\"pysd8\":\"" + pysd[8] + "\","
                          + "\"pysd9\":\"" + pysd[9] + "\","
                          + "\"pysd10\":\"" + pysd[10] + "\","
                          + "\"pysd11\":\"" + pysd[11] + "\","
                          + "\"pysd12\":\"" + pysd[12] + "\","
                          + "\"pysd13\":\"" + pysd[13] + "\","
                          + "\"pysd14\":\"" + pysd[14] + "\","
                          + "\"pysd15\":\"" + pysd[15] + "\","
                          + "\"pysd16\":\"" + pysd[16] + "\","
                          + "\"pysd17\":\"" + pysd[17] + "\","
                          + "\"pysd18\":\"" + pysd[18] + "\","
                          + "\"pysd19\":\"" + pysd[19] + "\","
                          + "\"pysd20\":\"" + pysd[20] + "\"}";
            return Content(json);
        }
        //平移设定写
        public ActionResult postDataPYSD()
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
                ROV[1] = opXML.ModifyNode("num1201", Request.Form["pysd1"]);
                ROV[2] = opXML.ModifyNode("num1202", Request.Form["pysd2"]);
                ROV[3] = opXML.ModifyNode("num1203", Request.Form["pysd3"]);
                ROV[4] = opXML.ModifyNode("num1204", Request.Form["pysd4"]);
                ROV[5] = opXML.ModifyNode("num1205", Request.Form["pysd5"]);
                ROV[6] = opXML.ModifyNode("num1206", Request.Form["pysd6"]);
                ROV[7] = opXML.ModifyNode("num1207", Request.Form["pysd7"]);
                ROV[8] = opXML.ModifyNode("num1208", Request.Form["pysd8"]);
                ROV[9] = opXML.ModifyNode("num1209", Request.Form["pysd9"]);
                ROV[10] = opXML.ModifyNode("num1210", Request.Form["pysd10"]);
                ROV[11] = opXML.ModifyNode("num1211", Request.Form["pysd11"]);
                ROV[12] = opXML.ModifyNode("num1212", Request.Form["pysd12"]);
                ROV[13] = opXML.ModifyNode("num1213", Request.Form["pysd13"]);
                ROV[14] = opXML.ModifyNode("num1214", Request.Form["pysd14"]);
                ROV[15] = opXML.ModifyNode("num1215", Request.Form["pysd15"]);
                ROV[16] = opXML.ModifyNode("num1216", Request.Form["pysd16"]);
                ROV[17] = opXML.ModifyNode("num1217", Request.Form["pysd17"]);
                ROV[18] = opXML.ModifyNode("num1218", Request.Form["pysd18"]);
                ROV[19] = opXML.ModifyNode("num1219", Request.Form["pysd19"]);
                ROV[20] = opXML.ModifyNode("num1220", Request.Form["pysd20"]);
                ROV[21] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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
        //灰度忽略读
        public ActionResult SendDataHDHL()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] hdhl = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            hdhl[1] = opXML.QueryNodeText("num2201");
            hdhl[2] = opXML.QueryNodeText("num2202");
            hdhl[3] = opXML.QueryNodeText("num2203");
            hdhl[4] = opXML.QueryNodeText("num2204");
            hdhl[5] = opXML.QueryNodeText("num2205");
            hdhl[6] = opXML.QueryNodeText("num2206");
            hdhl[7] = opXML.QueryNodeText("num2207");
            hdhl[8] = opXML.QueryNodeText("num2208");
            hdhl[9] = opXML.QueryNodeText("num2209");
            hdhl[10] = opXML.QueryNodeText("num2210");
            hdhl[11] = opXML.QueryNodeText("num2211");
            hdhl[12] = opXML.QueryNodeText("num2212");
            hdhl[13] = opXML.QueryNodeText("num2213");
            hdhl[14] = opXML.QueryNodeText("num2214");
            hdhl[15] = opXML.QueryNodeText("num2215");
            hdhl[16] = opXML.QueryNodeText("num2216");
            hdhl[17] = opXML.QueryNodeText("num2217");
            hdhl[18] = opXML.QueryNodeText("num2218");
            hdhl[19] = opXML.QueryNodeText("num2219");
            hdhl[20] = opXML.QueryNodeText("num2220");

            json = "{\"hdhl1\":\"" + hdhl[1] + "\","
                          + "\"hdhl2\":\"" + hdhl[2] + "\","
                          + "\"hdhl3\":\"" + hdhl[3] + "\","
                          + "\"hdhl4\":\"" + hdhl[4] + "\","
                          + "\"hdhl5\":\"" + hdhl[5] + "\","
                          + "\"hdhl6\":\"" + hdhl[6] + "\","
                          + "\"hdhl7\":\"" + hdhl[7] + "\","
                          + "\"hdhl8\":\"" + hdhl[8] + "\","
                          + "\"hdhl9\":\"" + hdhl[9] + "\","
                          + "\"hdhl10\":\"" + hdhl[10] + "\","
                          + "\"hdhl11\":\"" + hdhl[11] + "\","
                          + "\"hdhl12\":\"" + hdhl[12] + "\","
                          + "\"hdhl13\":\"" + hdhl[13] + "\","
                          + "\"hdhl14\":\"" + hdhl[14] + "\","
                          + "\"hdhl15\":\"" + hdhl[15] + "\","
                          + "\"hdhl16\":\"" + hdhl[16] + "\","
                          + "\"hdhl17\":\"" + hdhl[17] + "\","
                          + "\"hdhl18\":\"" + hdhl[18] + "\","
                          + "\"hdhl19\":\"" + hdhl[19] + "\","
                          + "\"hdhl20\":\"" + hdhl[20] + "\"}";
            return Content(json);
        }
        //灰度忽略写
        public ActionResult postDataHDHL()
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
                ROV[1] = opXML.ModifyNode("num2201", Request.Form["hdhl1"]);
                ROV[2] = opXML.ModifyNode("num2202", Request.Form["hdhl2"]);
                ROV[3] = opXML.ModifyNode("num2203", Request.Form["hdhl3"]);
                ROV[4] = opXML.ModifyNode("num2204", Request.Form["hdhl4"]);
                ROV[5] = opXML.ModifyNode("num2205", Request.Form["hdhl5"]);
                ROV[6] = opXML.ModifyNode("num2206", Request.Form["hdhl6"]);
                ROV[7] = opXML.ModifyNode("num2207", Request.Form["hdhl7"]);
                ROV[8] = opXML.ModifyNode("num2208", Request.Form["hdhl8"]);
                ROV[9] = opXML.ModifyNode("num2209", Request.Form["hdhl9"]);
                ROV[10] = opXML.ModifyNode("num2210", Request.Form["hdhl10"]);
                ROV[11] = opXML.ModifyNode("num2211", Request.Form["hdhl11"]);
                ROV[12] = opXML.ModifyNode("num2212", Request.Form["hdhl12"]);
                ROV[13] = opXML.ModifyNode("num2213", Request.Form["hdhl13"]);
                ROV[14] = opXML.ModifyNode("num2214", Request.Form["hdhl14"]);
                ROV[15] = opXML.ModifyNode("num2215", Request.Form["hdhl15"]);
                ROV[16] = opXML.ModifyNode("num2216", Request.Form["hdhl16"]);
                ROV[17] = opXML.ModifyNode("num2217", Request.Form["hdhl17"]);
                ROV[18] = opXML.ModifyNode("num2218", Request.Form["hdhl18"]);
                ROV[19] = opXML.ModifyNode("num2219", Request.Form["hdhl19"]);
                ROV[20] = opXML.ModifyNode("num2220", Request.Form["hdhl20"]);
                ROV[21] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 22; i++)
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

        //相机划分读
        public ActionResult SendDataXJHF()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] xjhf = new string[100];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            xjhf[1] = opXML.QueryNodeText("num1901");
            xjhf[2] = opXML.QueryNodeText("num1902");
            xjhf[3] = opXML.QueryNodeText("num1903");
            xjhf[4] = opXML.QueryNodeText("num1904");
            xjhf[5] = opXML.QueryNodeText("num1905");
            xjhf[6] = opXML.QueryNodeText("num1906");
            xjhf[7] = opXML.QueryNodeText("num1907");
            xjhf[8] = opXML.QueryNodeText("num1908");
            xjhf[9] = opXML.QueryNodeText("num1909");
            xjhf[10] = opXML.QueryNodeText("num1910");
            xjhf[11] = opXML.QueryNodeText("num1911");
            xjhf[12] = opXML.QueryNodeText("num1912");
            xjhf[13] = opXML.QueryNodeText("num1913");
            xjhf[14] = opXML.QueryNodeText("num1914");
            xjhf[15] = opXML.QueryNodeText("num1915");
            xjhf[16] = opXML.QueryNodeText("num1916");
            xjhf[17] = opXML.QueryNodeText("num1917");
            xjhf[18] = opXML.QueryNodeText("num1918");
            xjhf[19] = opXML.QueryNodeText("num1919");
            xjhf[20] = opXML.QueryNodeText("num1920");
            xjhf[21] = opXML.QueryNodeText("num1921");
            xjhf[22] = opXML.QueryNodeText("num1922");
            xjhf[23] = opXML.QueryNodeText("num1923");
            xjhf[24] = opXML.QueryNodeText("num1924");
            xjhf[25] = opXML.QueryNodeText("num1925");
            xjhf[26] = opXML.QueryNodeText("num1926");
            xjhf[27] = opXML.QueryNodeText("num1927");
            xjhf[28] = opXML.QueryNodeText("num1928");
            xjhf[29] = opXML.QueryNodeText("num1929");
            xjhf[30] = opXML.QueryNodeText("num1930");
            xjhf[31] = opXML.QueryNodeText("num1931");
            xjhf[32] = opXML.QueryNodeText("num1932");
            xjhf[33] = opXML.QueryNodeText("num1933");
            xjhf[34] = opXML.QueryNodeText("num1934");
            xjhf[35] = opXML.QueryNodeText("num1935");
            xjhf[36] = opXML.QueryNodeText("num1936");
            xjhf[37] = opXML.QueryNodeText("num1937");
            xjhf[38] = opXML.QueryNodeText("num1938");
            xjhf[39] = opXML.QueryNodeText("num1939");
            xjhf[40] = opXML.QueryNodeText("num1940");
            xjhf[41] = opXML.QueryNodeText("num1941");
            xjhf[42] = opXML.QueryNodeText("num1942");
            xjhf[43] = opXML.QueryNodeText("num1943");
            xjhf[44] = opXML.QueryNodeText("num1944");
            xjhf[45] = opXML.QueryNodeText("num1945");
            xjhf[46] = opXML.QueryNodeText("num1946");
            xjhf[47] = opXML.QueryNodeText("num1947");
            xjhf[48] = opXML.QueryNodeText("num1948");
            xjhf[49] = opXML.QueryNodeText("num1949");
            xjhf[50] = opXML.QueryNodeText("num1950");
            xjhf[51] = opXML.QueryNodeText("num1951");
            xjhf[52] = opXML.QueryNodeText("num1952");
            xjhf[53] = opXML.QueryNodeText("num1953");
            xjhf[54] = opXML.QueryNodeText("num1954");
            xjhf[55] = opXML.QueryNodeText("num1955");
            xjhf[56] = opXML.QueryNodeText("num1956");
            xjhf[57] = opXML.QueryNodeText("num1957");
            xjhf[58] = opXML.QueryNodeText("num1958");
            xjhf[59] = opXML.QueryNodeText("num1959");
            xjhf[60] = opXML.QueryNodeText("num1960");
            xjhf[61] = opXML.QueryNodeText("num1961");
            xjhf[62] = opXML.QueryNodeText("num1962");
            xjhf[63] = opXML.QueryNodeText("num1963");
            xjhf[64] = opXML.QueryNodeText("num1964");
            xjhf[65] = opXML.QueryNodeText("num1965");
            xjhf[66] = opXML.QueryNodeText("num1966");
            xjhf[67] = opXML.QueryNodeText("num1967");
            xjhf[68] = opXML.QueryNodeText("num1968");
            xjhf[69] = opXML.QueryNodeText("num1969");
            xjhf[70] = opXML.QueryNodeText("num1970");
            xjhf[71] = opXML.QueryNodeText("num1971");
            xjhf[72] = opXML.QueryNodeText("num1972");
            xjhf[73] = opXML.QueryNodeText("num1973");
            xjhf[74] = opXML.QueryNodeText("num1974");
            xjhf[75] = opXML.QueryNodeText("num1975");
            xjhf[76] = opXML.QueryNodeText("num1976");
            xjhf[77] = opXML.QueryNodeText("num1977");
            xjhf[78] = opXML.QueryNodeText("num1978");
            xjhf[79] = opXML.QueryNodeText("num1979");
            xjhf[80] = opXML.QueryNodeText("num1980");
            xjhf[81] = opXML.QueryNodeText("num1981");
            xjhf[82] = opXML.QueryNodeText("num1982");
            xjhf[83] = opXML.QueryNodeText("num1983");
            xjhf[84] = opXML.QueryNodeText("num1984");
            xjhf[85] = opXML.QueryNodeText("num1985");
            xjhf[86] = opXML.QueryNodeText("num1986");
            xjhf[87] = opXML.QueryNodeText("num1987");
            xjhf[88] = opXML.QueryNodeText("num1988");
            xjhf[89] = opXML.QueryNodeText("num1989");
            xjhf[90] = opXML.QueryNodeText("num1990");
            xjhf[91] = opXML.QueryNodeText("num1991");
            xjhf[92] = opXML.QueryNodeText("num1992");
            xjhf[93] = opXML.QueryNodeText("num1993");
            xjhf[94] = opXML.QueryNodeText("num1994");

            json = "{\"xjhf1\":\"" + xjhf[1] + "\","
                          + "\"xjhf2\":\"" + xjhf[2] + "\","
                          + "\"xjhf3\":\"" + xjhf[3] + "\","
                          + "\"xjhf4\":\"" + xjhf[4] + "\","
                          + "\"xjhf5\":\"" + xjhf[5] + "\","
                          + "\"xjhf6\":\"" + xjhf[6] + "\","
                          + "\"xjhf7\":\"" + xjhf[7] + "\","
                          + "\"xjhf8\":\"" + xjhf[8] + "\","
                          + "\"xjhf9\":\"" + xjhf[9] + "\","
                          + "\"xjhf10\":\"" + xjhf[10] + "\","
                          + "\"xjhf11\":\"" + xjhf[11] + "\","
                          + "\"xjhf12\":\"" + xjhf[12] + "\","
                          + "\"xjhf13\":\"" + xjhf[13] + "\","
                          + "\"xjhf14\":\"" + xjhf[14] + "\","
                          + "\"xjhf15\":\"" + xjhf[15] + "\","
                          + "\"xjhf16\":\"" + xjhf[16] + "\","
                          + "\"xjhf17\":\"" + xjhf[17] + "\","
                          + "\"xjhf18\":\"" + xjhf[18] + "\","
                          + "\"xjhf19\":\"" + xjhf[19] + "\","
                          + "\"xjhf20\":\"" + xjhf[20] + "\","
                          + "\"xjhf21\":\"" + xjhf[21] + "\","
                          + "\"xjhf22\":\"" + xjhf[22] + "\","
                          + "\"xjhf23\":\"" + xjhf[23] + "\","
                          + "\"xjhf24\":\"" + xjhf[24] + "\","
                          + "\"xjhf25\":\"" + xjhf[25] + "\","
                          + "\"xjhf26\":\"" + xjhf[26] + "\","
                          + "\"xjhf27\":\"" + xjhf[27] + "\","
                          + "\"xjhf28\":\"" + xjhf[28] + "\","
                          + "\"xjhf29\":\"" + xjhf[29] + "\","
                          + "\"xjhf30\":\"" + xjhf[30] + "\","
                          + "\"xjhf31\":\"" + xjhf[31] + "\","
                          + "\"xjhf32\":\"" + xjhf[32] + "\","
                          + "\"xjhf33\":\"" + xjhf[33] + "\","
                          + "\"xjhf34\":\"" + xjhf[34] + "\","
                          + "\"xjhf35\":\"" + xjhf[35] + "\","
                          + "\"xjhf36\":\"" + xjhf[36] + "\","
                          + "\"xjhf37\":\"" + xjhf[37] + "\","
                          + "\"xjhf38\":\"" + xjhf[38] + "\","
                          + "\"xjhf39\":\"" + xjhf[39] + "\","
                          + "\"xjhf40\":\"" + xjhf[40] + "\","
                          + "\"xjhf41\":\"" + xjhf[41] + "\","
                          + "\"xjhf42\":\"" + xjhf[42] + "\","
                          + "\"xjhf43\":\"" + xjhf[43] + "\","
                          + "\"xjhf44\":\"" + xjhf[44] + "\","
                          + "\"xjhf45\":\"" + xjhf[45] + "\","
                          + "\"xjhf46\":\"" + xjhf[46] + "\","
                          + "\"xjhf47\":\"" + xjhf[47] + "\","
                          + "\"xjhf48\":\"" + xjhf[48] + "\","
                          + "\"xjhf49\":\"" + xjhf[49] + "\","
                          + "\"xjhf50\":\"" + xjhf[50] + "\","
                          + "\"xjhf51\":\"" + xjhf[51] + "\","
                          + "\"xjhf52\":\"" + xjhf[52] + "\","
                          + "\"xjhf53\":\"" + xjhf[53] + "\","
                          + "\"xjhf54\":\"" + xjhf[54] + "\","
                          + "\"xjhf55\":\"" + xjhf[55] + "\","
                          + "\"xjhf56\":\"" + xjhf[56] + "\","
                          + "\"xjhf57\":\"" + xjhf[57] + "\","
                          + "\"xjhf58\":\"" + xjhf[58] + "\","
                          + "\"xjhf59\":\"" + xjhf[59] + "\","
                          + "\"xjhf60\":\"" + xjhf[60] + "\","
                          + "\"xjhf61\":\"" + xjhf[61] + "\","
                          + "\"xjhf62\":\"" + xjhf[62] + "\","
                          + "\"xjhf63\":\"" + xjhf[63] + "\","
                          + "\"xjhf64\":\"" + xjhf[64] + "\","
                          + "\"xjhf65\":\"" + xjhf[65] + "\","
                          + "\"xjhf66\":\"" + xjhf[66] + "\","
                          + "\"xjhf67\":\"" + xjhf[67] + "\","
                          + "\"xjhf68\":\"" + xjhf[68] + "\","
                          + "\"xjhf69\":\"" + xjhf[69] + "\","
                          + "\"xjhf70\":\"" + xjhf[70] + "\","
                          + "\"xjhf71\":\"" + xjhf[71] + "\","
                          + "\"xjhf72\":\"" + xjhf[72] + "\","
                          + "\"xjhf73\":\"" + xjhf[73] + "\","
                          + "\"xjhf74\":\"" + xjhf[74] + "\","
                          + "\"xjhf75\":\"" + xjhf[75] + "\","
                          + "\"xjhf76\":\"" + xjhf[76] + "\","
                          + "\"xjhf77\":\"" + xjhf[77] + "\","
                          + "\"xjhf78\":\"" + xjhf[78] + "\","
                          + "\"xjhf79\":\"" + xjhf[79] + "\","
                          + "\"xjhf80\":\"" + xjhf[80] + "\","
                          + "\"xjhf81\":\"" + xjhf[81] + "\","
                          + "\"xjhf82\":\"" + xjhf[82] + "\","
                          + "\"xjhf83\":\"" + xjhf[83] + "\","
                          + "\"xjhf84\":\"" + xjhf[84] + "\","
                          + "\"xjhf85\":\"" + xjhf[85] + "\","
                          + "\"xjhf86\":\"" + xjhf[86] + "\","
                          + "\"xjhf87\":\"" + xjhf[87] + "\","
                          + "\"xjhf88\":\"" + xjhf[88] + "\","
                          + "\"xjhf89\":\"" + xjhf[89] + "\","
                          + "\"xjhf90\":\"" + xjhf[90] + "\","
                          + "\"xjhf91\":\"" + xjhf[91] + "\","
                          + "\"xjhf92\":\"" + xjhf[92] + "\","
                          + "\"xjhf93\":\"" + xjhf[93] + "\","
                          + "\"xjhf94\":\"" + xjhf[94] + "\"}";
            return Content(json);
        }
        //相机划分写
        public ActionResult postDataXJHF()
        {           //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[100];
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
                ROV[1] = opXML.ModifyNode("num1901", Request.Form["xjhf1"]);
                ROV[2] = opXML.ModifyNode("num1902", Request.Form["xjhf2"]);
                ROV[3] = opXML.ModifyNode("num1903", Request.Form["xjhf3"]);
                ROV[4] = opXML.ModifyNode("num1904", Request.Form["xjhf4"]);
                ROV[5] = opXML.ModifyNode("num1905", Request.Form["xjhf5"]);
                ROV[6] = opXML.ModifyNode("num1906", Request.Form["xjhf6"]);
                ROV[7] = opXML.ModifyNode("num1907", Request.Form["xjhf7"]);
                ROV[8] = opXML.ModifyNode("num1908", Request.Form["xjhf8"]);
                ROV[9] = opXML.ModifyNode("num1909", Request.Form["xjhf9"]);
                ROV[10] = opXML.ModifyNode("num1910", Request.Form["xjhf10"]);
                ROV[11] = opXML.ModifyNode("num1911", Request.Form["xjhf11"]);
                ROV[12] = opXML.ModifyNode("num1912", Request.Form["xjhf12"]);
                ROV[13] = opXML.ModifyNode("num1913", Request.Form["xjhf13"]);
                ROV[14] = opXML.ModifyNode("num1914", Request.Form["xjhf14"]);
                ROV[15] = opXML.ModifyNode("num1915", Request.Form["xjhf15"]);
                ROV[16] = opXML.ModifyNode("num1916", Request.Form["xjhf16"]);
                ROV[17] = opXML.ModifyNode("num1917", Request.Form["xjhf17"]);
                ROV[18] = opXML.ModifyNode("num1918", Request.Form["xjhf18"]);
                ROV[19] = opXML.ModifyNode("num1919", Request.Form["xjhf19"]);
                ROV[20] = opXML.ModifyNode("num1920", Request.Form["xjhf20"]);

                ROV[21] = opXML.ModifyNode("num1921", Request.Form["xjhf21"]);
                ROV[22] = opXML.ModifyNode("num1922", Request.Form["xjhf22"]);
                ROV[23] = opXML.ModifyNode("num1923", Request.Form["xjhf23"]);
                ROV[24] = opXML.ModifyNode("num1924", Request.Form["xjhf24"]);
                ROV[25] = opXML.ModifyNode("num1925", Request.Form["xjhf25"]);
                ROV[26] = opXML.ModifyNode("num1926", Request.Form["xjhf26"]);
                ROV[27] = opXML.ModifyNode("num1927", Request.Form["xjhf27"]);
                ROV[28] = opXML.ModifyNode("num1928", Request.Form["xjhf28"]);
                ROV[29] = opXML.ModifyNode("num1929", Request.Form["xjhf29"]);
                ROV[30] = opXML.ModifyNode("num1930", Request.Form["xjhf30"]);
                ROV[31] = opXML.ModifyNode("num1931", Request.Form["xjhf31"]);
                ROV[32] = opXML.ModifyNode("num1932", Request.Form["xjhf32"]);
                ROV[33] = opXML.ModifyNode("num1933", Request.Form["xjhf33"]);
                ROV[34] = opXML.ModifyNode("num1934", Request.Form["xjhf34"]);
                ROV[35] = opXML.ModifyNode("num1935", Request.Form["xjhf35"]);
                ROV[36] = opXML.ModifyNode("num1936", Request.Form["xjhf36"]);
                ROV[37] = opXML.ModifyNode("num1937", Request.Form["xjhf37"]);
                ROV[38] = opXML.ModifyNode("num1938", Request.Form["xjhf38"]);
                ROV[39] = opXML.ModifyNode("num1939", Request.Form["xjhf39"]);
                ROV[40] = opXML.ModifyNode("num1940", Request.Form["xjhf40"]);
                ROV[41] = opXML.ModifyNode("num1941", Request.Form["xjhf41"]);
                ROV[42] = opXML.ModifyNode("num1942", Request.Form["xjhf42"]);
                ROV[43] = opXML.ModifyNode("num1943", Request.Form["xjhf43"]);
                ROV[44] = opXML.ModifyNode("num1944", Request.Form["xjhf44"]);
                ROV[45] = opXML.ModifyNode("num1945", Request.Form["xjhf45"]);
                ROV[46] = opXML.ModifyNode("num1946", Request.Form["xjhf46"]);
                ROV[47] = opXML.ModifyNode("num1947", Request.Form["xjhf47"]);
                ROV[48] = opXML.ModifyNode("num1948", Request.Form["xjhf48"]);
                ROV[49] = opXML.ModifyNode("num1949", Request.Form["xjhf49"]);
                ROV[50] = opXML.ModifyNode("num1950", Request.Form["xjhf50"]);
                ROV[51] = opXML.ModifyNode("num1951", Request.Form["xjhf51"]);
                ROV[52] = opXML.ModifyNode("num1952", Request.Form["xjhf52"]);
                ROV[53] = opXML.ModifyNode("num1953", Request.Form["xjhf53"]);
                ROV[54] = opXML.ModifyNode("num1954", Request.Form["xjhf54"]);
                ROV[55] = opXML.ModifyNode("num1955", Request.Form["xjhf55"]);
                ROV[56] = opXML.ModifyNode("num1956", Request.Form["xjhf56"]);
                ROV[57] = opXML.ModifyNode("num1957", Request.Form["xjhf57"]);
                ROV[58] = opXML.ModifyNode("num1958", Request.Form["xjhf58"]);
                ROV[59] = opXML.ModifyNode("num1959", Request.Form["xjhf59"]);
                ROV[60] = opXML.ModifyNode("num1960", Request.Form["xjhf60"]);
                ROV[61] = opXML.ModifyNode("num1961", Request.Form["xjhf61"]);
                ROV[62] = opXML.ModifyNode("num1962", Request.Form["xjhf62"]);
                ROV[63] = opXML.ModifyNode("num1963", Request.Form["xjhf63"]);
                ROV[64] = opXML.ModifyNode("num1964", Request.Form["xjhf64"]);
                ROV[65] = opXML.ModifyNode("num1965", Request.Form["xjhf65"]);
                ROV[66] = opXML.ModifyNode("num1966", Request.Form["xjhf66"]);
                ROV[67] = opXML.ModifyNode("num1967", Request.Form["xjhf67"]);
                ROV[68] = opXML.ModifyNode("num1968", Request.Form["xjhf68"]);
                ROV[69] = opXML.ModifyNode("num1969", Request.Form["xjhf69"]);
                ROV[70] = opXML.ModifyNode("num1970", Request.Form["xjhf70"]);
                ROV[71] = opXML.ModifyNode("num1971", Request.Form["xjhf71"]);
                ROV[72] = opXML.ModifyNode("num1972", Request.Form["xjhf72"]);
                ROV[73] = opXML.ModifyNode("num1973", Request.Form["xjhf73"]);
                ROV[74] = opXML.ModifyNode("num1974", Request.Form["xjhf74"]);
                ROV[75] = opXML.ModifyNode("num1975", Request.Form["xjhf75"]);
                ROV[76] = opXML.ModifyNode("num1976", Request.Form["xjhf76"]);
                ROV[77] = opXML.ModifyNode("num1977", Request.Form["xjhf77"]);
                ROV[78] = opXML.ModifyNode("num1978", Request.Form["xjhf78"]);
                ROV[79] = opXML.ModifyNode("num1979", Request.Form["xjhf79"]);
                ROV[80] = opXML.ModifyNode("num1980", Request.Form["xjhf80"]);
                ROV[81] = opXML.ModifyNode("num1981", Request.Form["xjhf81"]);
                ROV[82] = opXML.ModifyNode("num1982", Request.Form["xjhf82"]);
                ROV[83] = opXML.ModifyNode("num1983", Request.Form["xjhf83"]);
                ROV[84] = opXML.ModifyNode("num1984", Request.Form["xjhf84"]);
                ROV[85] = opXML.ModifyNode("num1985", Request.Form["xjhf85"]);
                ROV[86] = opXML.ModifyNode("num1986", Request.Form["xjhf86"]);
                ROV[87] = opXML.ModifyNode("num1987", Request.Form["xjhf87"]);
                ROV[88] = opXML.ModifyNode("num1988", Request.Form["xjhf88"]);
                ROV[89] = opXML.ModifyNode("num1989", Request.Form["xjhf89"]);
                ROV[90] = opXML.ModifyNode("num1990", Request.Form["xjhf90"]);
                ROV[91] = opXML.ModifyNode("num1991", Request.Form["xjhf91"]);
                ROV[92] = opXML.ModifyNode("num1992", Request.Form["xjhf92"]);
                ROV[93] = opXML.ModifyNode("num1993", Request.Form["xjhf93"]);
                ROV[94] = opXML.ModifyNode("num1994", Request.Form["xjhf94"]);
                ROV[95] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 96; i++)
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

        //延迟设定读
        public ActionResult SendDataYCSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] ycsd = new string[20];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            ycsd[1] = opXML.QueryNodeText("num2001");
            ycsd[2] = opXML.QueryNodeText("num2002");
            ycsd[3] = opXML.QueryNodeText("num2003");
            ycsd[4] = opXML.QueryNodeText("num2004");
            ycsd[5] = opXML.QueryNodeText("num2005");
            ycsd[6] = opXML.QueryNodeText("num2006");
            ycsd[7] = opXML.QueryNodeText("num2007");
            ycsd[8] = opXML.QueryNodeText("num2008");
            ycsd[9] = opXML.QueryNodeText("num2009");
            ycsd[10] = opXML.QueryNodeText("num2010");
            ycsd[11] = opXML.QueryNodeText("num2011");

            json = "{\"ycsd1\":\"" + ycsd[1] + "\","
                          + "\"ycsd2\":\"" + ycsd[2] + "\","
                          + "\"ycsd3\":\"" + ycsd[3] + "\","
                          + "\"ycsd4\":\"" + ycsd[4] + "\","
                          + "\"ycsd5\":\"" + ycsd[5] + "\","
                          + "\"ycsd6\":\"" + ycsd[6] + "\","
                          + "\"ycsd7\":\"" + ycsd[7] + "\","
                          + "\"ycsd8\":\"" + ycsd[8] + "\","
                          + "\"ycsd9\":\"" + ycsd[9] + "\","
                          + "\"ycsd10\":\"" + ycsd[10] + "\","
                          + "\"ycsd11\":\"" + ycsd[11] + "\"}";
            return Content(json);
        }
        //延迟设定写
        public ActionResult postDataYCSD()
        {         //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[15];
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
                ROV[1] = opXML.ModifyNode("num2001", Request.Form["ycsd1"]);
                ROV[2] = opXML.ModifyNode("num2002", Request.Form["ycsd2"]);
                ROV[3] = opXML.ModifyNode("num2003", Request.Form["ycsd3"]);
                ROV[4] = opXML.ModifyNode("num2004", Request.Form["ycsd4"]);
                ROV[5] = opXML.ModifyNode("num2005", Request.Form["ycsd5"]);
                ROV[6] = opXML.ModifyNode("num2006", Request.Form["ycsd6"]);
                ROV[7] = opXML.ModifyNode("num2007", Request.Form["ycsd7"]);
                ROV[8] = opXML.ModifyNode("num2008", Request.Form["ycsd8"]);
                ROV[9] = opXML.ModifyNode("num2009", Request.Form["ycsd9"]);
                ROV[10] = opXML.ModifyNode("num2010", Request.Form["ycsd10"]);
                ROV[11] = opXML.ModifyNode("num2011", Request.Form["ycsd11"]);
                ROV[12] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 13; i++)
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
       
        //通信状态读
        public ActionResult SendDataCommState()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] commState = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            commState[1] = opXML.QueryNodeText("num4901");
            commState[2] = opXML.QueryNodeText("num4902");
            commState[3] = opXML.QueryNodeText("num4903");
            commState[4] = opXML.QueryNodeText("num4904");
            commState[5] = opXML.QueryNodeText("num4905");
            commState[6] = opXML.QueryNodeText("num4906");
            commState[7] = opXML.QueryNodeText("num4907");
            commState[8] = opXML.QueryNodeText("num4908");
            commState[9] = opXML.QueryNodeText("num4909");
            commState[10] = opXML.QueryNodeText("num4910");
            commState[11] = opXML.QueryNodeText("num4911");
            commState[12] = opXML.QueryNodeText("num4912");
            commState[13] = opXML.QueryNodeText("num4913");
            commState[14] = opXML.QueryNodeText("num4914");
            commState[15] = opXML.QueryNodeText("num4915");
            commState[16] = opXML.QueryNodeText("num4916");
            commState[17] = opXML.QueryNodeText("num4917");
            commState[18] = opXML.QueryNodeText("num4918");
            commState[19] = opXML.QueryNodeText("num4919");
            commState[20] = opXML.QueryNodeText("num4920");
            commState[21] = opXML.QueryNodeText("num4921");

            json = "{\"zhuban\":\"" + commState[1] + "\","
                          + "\"xiangji1\":\"" + commState[2] + "\","
                          + "\"xiangji2\":\"" + commState[3] + "\","
                          + "\"xiangji3\":\"" + commState[4] + "\","
                          + "\"xiangji4\":\"" + commState[5] + "\","
                          + "\"xiangji5\":\"" + commState[6] + "\","
                          + "\"xiangji6\":\"" + commState[7] + "\","
                          + "\"xiangji7\":\"" + commState[8] + "\","
                          + "\"xiangji8\":\"" + commState[9] + "\","
                          + "\"xiangji9\":\"" + commState[10] + "\","
                          + "\"xiangji10\":\"" + commState[11] + "\","
                          + "\"xiangji11\":\"" + commState[12] + "\","
                          + "\"xiangji12\":\"" + commState[13] + "\","
                          + "\"xiangji13\":\"" + commState[14] + "\","
                          + "\"xiangji14\":\"" + commState[15] + "\","
                          + "\"xiangji15\":\"" + commState[16] + "\","
                          + "\"xiangji16\":\"" + commState[17] + "\","
                          + "\"xiangji17\":\"" + commState[18] + "\","
                          + "\"xiangji18\":\"" + commState[19] + "\","
                          + "\"xiangji19\":\"" + commState[20] + "\","
                          + "\"xiangji20\":\"" + commState[21] + "\"}";
            return Content(json);
        }



        //使用日期设定读
        public ActionResult SendDataCD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string expiryDate;
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            expiryDate = opXML.QueryNodeText("jzsj");

            json = "{\"expiryDate\":\"" + expiryDate + "\"}";
            return Content(json);
        }
        //使用日期设定写
        public ActionResult postDataCD()
        {         //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, hs_sql, path, newPath, expiryDate;
            //ROV是Return on Value返回值
            bool[] ROV = new bool[10];
            deviceID = Request.Form["deviceID"];
            expiryDate = Request.Form["expiryDate"];
            try
            {
                DateTime.Parse(expiryDate);
                //获得文件路径
                hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
                path = DbHelperSQL.ExecuteQuery(hs_sql);
                newPath = System.IO.Path.Combine(path, "tmp.xml");
                XMLHelper opXML = new XMLHelper(newPath);
                ROV[1] = opXML.ModifyNode("jzsj", expiryDate);
                ROV[2] = opXML.saveFile();
                //用ROV判断写入是否成功，false失败
                for (int i = 1; i < 3; i++)
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