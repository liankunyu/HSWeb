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
    public class ColorSensitiveController : Controller
    {
        // GET: ColorSensitive
        public ActionResult ColorSensitive()
        {
            return View();
        }
        public ActionResult quyu1()
        {
            return View();
        }
        public ActionResult quyu2()
        {
            return View();
        }
        public ActionResult quyu3()
        {
            return View();
        }
        public ActionResult quyu4()
        {
            return View();
        }
        public ActionResult quyu5()
        {
            return View();
        }
        public ActionResult huidu1()
        {
            return View();
        }
        public ActionResult huidu2()
        {
            return View();
        }
        public ActionResult shendu1()
        {
            return View();
        }
        public ActionResult shendu2()
        {
            return View();
        }
        public ActionResult yansehangmianji()
        {
            return View();
        }
        public ActionResult beijingyuzhi()
        {
            return View();
        }
        public ActionResult yanseminganqiangdu()
        {
            return View();
        }

        //区域一读
        public ActionResult SendData()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] quyu = new string[20];
            string[] quyuf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            quyu[1] = opXML.QueryNodeText("num2101");
            quyu[2] = opXML.QueryNodeText("num2102");
            quyu[3] = opXML.QueryNodeText("num2103");
            quyu[4] = opXML.QueryNodeText("num2104");
            quyu[5] = opXML.QueryNodeText("num2105");
            quyu[6] = opXML.QueryNodeText("num2106");
            quyu[7] = opXML.QueryNodeText("num2107");
            quyu[8] = opXML.QueryNodeText("num2108");
            quyu[9] = opXML.QueryNodeText("num2109");
            quyu[10] = opXML.QueryNodeText("num2110");
            quyu[11] = opXML.QueryNodeText("num2111");
            quyu[12] = opXML.QueryNodeText("num2112");

            quyuf[1] = opXML.QueryNodeText("num4001");
            quyuf[2] = opXML.QueryNodeText("num4002");
            quyuf[3] = opXML.QueryNodeText("num4003");
            quyuf[4] = opXML.QueryNodeText("num4004");
            quyuf[5] = opXML.QueryNodeText("num4005");
            quyuf[6] = opXML.QueryNodeText("num4006");
            quyuf[7] = opXML.QueryNodeText("num4007");
            quyuf[8] = opXML.QueryNodeText("num4008");
            quyuf[9] = opXML.QueryNodeText("num4009");
            quyuf[10] = opXML.QueryNodeText("num4010");
            quyuf[11] = opXML.QueryNodeText("num4011");
            quyuf[12] = opXML.QueryNodeText("num4012");
            quyuf[13] = opXML.QueryNodeText("num4013");
            quyuf[14] = opXML.QueryNodeText("num4014");
            quyuf[15] = opXML.QueryNodeText("num4015");
            quyuf[16] = opXML.QueryNodeText("num4016");
            quyuf[17] = opXML.QueryNodeText("num4017");
            quyuf[18] = opXML.QueryNodeText("num4018");
            quyuf[19] = opXML.QueryNodeText("num4019");
            quyuf[20] = opXML.QueryNodeText("num4020");
            quyuf[21] = opXML.QueryNodeText("num4021");
            quyuf[22] = opXML.QueryNodeText("num4022");
            quyuf[23] = opXML.QueryNodeText("num4023");
            quyuf[24] = opXML.QueryNodeText("num4024");
            quyuf[25] = opXML.QueryNodeText("num4025");
            quyuf[26] = opXML.QueryNodeText("num4026");
            quyuf[27] = opXML.QueryNodeText("num4027");
            quyuf[28] = opXML.QueryNodeText("num4028");
            quyuf[29] = opXML.QueryNodeText("num4029");
            quyuf[30] = opXML.QueryNodeText("num4030");
            quyuf[31] = opXML.QueryNodeText("num4031");
            quyuf[32] = opXML.QueryNodeText("num4032");
            quyuf[33] = opXML.QueryNodeText("num4033");
            quyuf[34] = opXML.QueryNodeText("num4034");
            quyuf[35] = opXML.QueryNodeText("num4035");
            quyuf[36] = opXML.QueryNodeText("num4036");
            quyuf[37] = opXML.QueryNodeText("num4037");
            quyuf[38] = opXML.QueryNodeText("num4038");
            quyuf[39] = opXML.QueryNodeText("num4039");
            quyuf[40] = opXML.QueryNodeText("num4040");

            json = "{\"quyu1\":\"" + quyu[1] + "\","
                          + "\"quyu2\":\"" + quyu[2] + "\","
                          + "\"quyu3\":\"" + quyu[3] + "\","
                          + "\"quyu4\":\"" + quyu[4] + "\","
                          + "\"quyu5\":\"" + quyu[5] + "\","
                          + "\"quyu6\":\"" + quyu[6] + "\","
                          + "\"quyu7\":\"" + quyu[7] + "\","
                          + "\"quyu8\":\"" + quyu[8] + "\","
                          + "\"quyu9\":\"" + quyu[9] + "\","
                          + "\"quyu10\":\"" + quyu[10] + "\","
                          + "\"quyu11\":\"" + quyu[11] + "\","
                          + "\"quyu12\":\"" + quyu[12] + "\","
                            
                          + "\"quyuf1\":\"" + quyuf[1] + "\","
                          + "\"quyuf2\":\"" + quyuf[2] + "\","
                          + "\"quyuf3\":\"" + quyuf[3] + "\","
                          + "\"quyuf4\":\"" + quyuf[4] + "\","
                          + "\"quyuf5\":\"" + quyuf[5] + "\","
                          + "\"quyuf6\":\"" + quyuf[6] + "\","
                          + "\"quyuf7\":\"" + quyuf[7] + "\","
                          + "\"quyuf8\":\"" + quyuf[8] + "\","
                          + "\"quyuf9\":\"" + quyuf[9] + "\","
                          + "\"quyuf10\":\"" + quyuf[10] + "\","
                          + "\"quyuf11\":\"" + quyuf[11] + "\","
                          + "\"quyuf12\":\"" + quyuf[12] + "\","
                          + "\"quyuf13\":\"" + quyuf[13] + "\","
                          + "\"quyuf14\":\"" + quyuf[14] + "\","
                          + "\"quyuf15\":\"" + quyuf[15] + "\","
                          + "\"quyuf16\":\"" + quyuf[16] + "\","
                          + "\"quyuf17\":\"" + quyuf[17] + "\","
                          + "\"quyuf18\":\"" + quyuf[18] + "\","
                          + "\"quyuf19\":\"" + quyuf[19] + "\","
                          + "\"quyuf20\":\"" + quyuf[20] + "\","
                          + "\"quyuf21\":\"" + quyuf[21] + "\","
                          + "\"quyuf22\":\"" + quyuf[22] + "\","
                          + "\"quyuf23\":\"" + quyuf[23] + "\","
                          + "\"quyuf24\":\"" + quyuf[24] + "\","
                          + "\"quyuf25\":\"" + quyuf[25] + "\","
                          + "\"quyuf26\":\"" + quyuf[26] + "\","
                          + "\"quyuf27\":\"" + quyuf[27] + "\","
                          + "\"quyuf28\":\"" + quyuf[28] + "\","
                          + "\"quyuf29\":\"" + quyuf[29] + "\","
                          + "\"quyuf30\":\"" + quyuf[30] + "\","
                          + "\"quyuf31\":\"" + quyuf[31] + "\","
                          + "\"quyuf32\":\"" + quyuf[32] + "\","
                          + "\"quyuf33\":\"" + quyuf[33] + "\","
                          + "\"quyuf34\":\"" + quyuf[34] + "\","
                          + "\"quyuf35\":\"" + quyuf[35] + "\","
                          + "\"quyuf36\":\"" + quyuf[36] + "\","
                          + "\"quyuf37\":\"" + quyuf[37] + "\","
                          + "\"quyuf38\":\"" + quyuf[38] + "\","
                          + "\"quyuf39\":\"" + quyuf[39] + "\","
                          + "\"quyuf40\":\"" + quyuf[40] +  "\"}";
            return Content(json);
        }

        //区域一写
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
                opXML.ModifyNode("num2101", Request.Form["quyu1"]);
                opXML.ModifyNode("num2102", Request.Form["quyu2"]);
                opXML.ModifyNode("num2103", Request.Form["quyu3"]);
                opXML.ModifyNode("num2104", Request.Form["quyu4"]);
                opXML.ModifyNode("num2105", Request.Form["quyu5"]);
                opXML.ModifyNode("num2106", Request.Form["quyu6"]);
                opXML.ModifyNode("num2107", Request.Form["quyu7"]);
                opXML.ModifyNode("num2108", Request.Form["quyu8"]);
                opXML.ModifyNode("num2109", Request.Form["quyu9"]);
                opXML.ModifyNode("num2110", Request.Form["quyu10"]);
                opXML.ModifyNode("num2111", Request.Form["quyu11"]);
                opXML.ModifyNode("num2112", Request.Form["quyu12"]);

                opXML.ModifyNode("num4001", Request.Form["quyuf1"]);
                opXML.ModifyNode("num4002", Request.Form["quyuf2"]);
                opXML.ModifyNode("num4003", Request.Form["quyuf3"]);
                opXML.ModifyNode("num4004", Request.Form["quyuf4"]);
                opXML.ModifyNode("num4005", Request.Form["quyuf5"]);
                opXML.ModifyNode("num4006", Request.Form["quyuf6"]);
                opXML.ModifyNode("num4007", Request.Form["quyuf7"]);
                opXML.ModifyNode("num4008", Request.Form["quyuf8"]);
                opXML.ModifyNode("num4009", Request.Form["quyuf9"]);
                opXML.ModifyNode("num4010", Request.Form["quyuf10"]);
                opXML.ModifyNode("num4011", Request.Form["quyuf11"]);
                opXML.ModifyNode("num4012", Request.Form["quyuf12"]);
                opXML.ModifyNode("num4013", Request.Form["quyuf13"]);
                opXML.ModifyNode("num4014", Request.Form["quyuf14"]);
                opXML.ModifyNode("num4015", Request.Form["quyuf15"]);
                opXML.ModifyNode("num4016", Request.Form["quyuf16"]);
                opXML.ModifyNode("num4017", Request.Form["quyuf17"]);
                opXML.ModifyNode("num4018", Request.Form["quyuf18"]);
                opXML.ModifyNode("num4019", Request.Form["quyuf19"]);
                opXML.ModifyNode("num4020", Request.Form["quyuf20"]);
                opXML.ModifyNode("num4021", Request.Form["quyuf21"]);
                opXML.ModifyNode("num4022", Request.Form["quyuf22"]);
                opXML.ModifyNode("num4023", Request.Form["quyuf23"]);
                opXML.ModifyNode("num4024", Request.Form["quyuf24"]);
                opXML.ModifyNode("num4025", Request.Form["quyuf25"]);
                opXML.ModifyNode("num4026", Request.Form["quyuf26"]);
                opXML.ModifyNode("num4027", Request.Form["quyuf27"]);
                opXML.ModifyNode("num4028", Request.Form["quyuf28"]);
                opXML.ModifyNode("num4029", Request.Form["quyuf29"]);
                opXML.ModifyNode("num4030", Request.Form["quyuf30"]);
                opXML.ModifyNode("num4031", Request.Form["quyuf31"]);
                opXML.ModifyNode("num4032", Request.Form["quyuf32"]);
                opXML.ModifyNode("num4033", Request.Form["quyuf33"]);
                opXML.ModifyNode("num4034", Request.Form["quyuf34"]);
                opXML.ModifyNode("num4035", Request.Form["quyuf35"]);
                opXML.ModifyNode("num4036", Request.Form["quyuf36"]);
                opXML.ModifyNode("num4037", Request.Form["quyuf37"]);
                opXML.ModifyNode("num4038", Request.Form["quyuf38"]);
                opXML.ModifyNode("num4039", Request.Form["quyuf39"]);
                opXML.ModifyNode("num4040", Request.Form["quyuf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //区域二读
        public ActionResult SendData2()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] quyuer = new string[20];
            string[] quyuerf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            quyuer[1] = opXML.QueryNodeText("num1401");
            quyuer[2] = opXML.QueryNodeText("num1402");
            quyuer[3] = opXML.QueryNodeText("num1403");
            quyuer[4] = opXML.QueryNodeText("num1404");
            quyuer[5] = opXML.QueryNodeText("num1405");
            quyuer[6] = opXML.QueryNodeText("num1406");
            quyuer[7] = opXML.QueryNodeText("num1407");
            quyuer[8] = opXML.QueryNodeText("num1408");
            quyuer[9] = opXML.QueryNodeText("num1409");
            quyuer[10] = opXML.QueryNodeText("num1410");
            quyuer[11] = opXML.QueryNodeText("num1411");
            quyuer[12] = opXML.QueryNodeText("num1412");

            quyuerf[1] = opXML.QueryNodeText("num4101");
            quyuerf[2] = opXML.QueryNodeText("num4102");
            quyuerf[3] = opXML.QueryNodeText("num4103");
            quyuerf[4] = opXML.QueryNodeText("num4104");
            quyuerf[5] = opXML.QueryNodeText("num4105");
            quyuerf[6] = opXML.QueryNodeText("num4106");
            quyuerf[7] = opXML.QueryNodeText("num4107");
            quyuerf[8] = opXML.QueryNodeText("num4108");
            quyuerf[9] = opXML.QueryNodeText("num4109");
            quyuerf[10] = opXML.QueryNodeText("num4110");
            quyuerf[11] = opXML.QueryNodeText("num4111");
            quyuerf[12] = opXML.QueryNodeText("num4112");
            quyuerf[13] = opXML.QueryNodeText("num4113");
            quyuerf[14] = opXML.QueryNodeText("num4114");
            quyuerf[15] = opXML.QueryNodeText("num4115");
            quyuerf[16] = opXML.QueryNodeText("num4116");
            quyuerf[17] = opXML.QueryNodeText("num4117");
            quyuerf[18] = opXML.QueryNodeText("num4118");
            quyuerf[19] = opXML.QueryNodeText("num4119");
            quyuerf[20] = opXML.QueryNodeText("num4120");
            quyuerf[21] = opXML.QueryNodeText("num4121");
            quyuerf[22] = opXML.QueryNodeText("num4122");
            quyuerf[23] = opXML.QueryNodeText("num4123");
            quyuerf[24] = opXML.QueryNodeText("num4124");
            quyuerf[25] = opXML.QueryNodeText("num4125");
            quyuerf[26] = opXML.QueryNodeText("num4126");
            quyuerf[27] = opXML.QueryNodeText("num4127");
            quyuerf[28] = opXML.QueryNodeText("num4128");
            quyuerf[29] = opXML.QueryNodeText("num4129");
            quyuerf[30] = opXML.QueryNodeText("num4130");
            quyuerf[31] = opXML.QueryNodeText("num4131");
            quyuerf[32] = opXML.QueryNodeText("num4132");
            quyuerf[33] = opXML.QueryNodeText("num4133");
            quyuerf[34] = opXML.QueryNodeText("num4134");
            quyuerf[35] = opXML.QueryNodeText("num4135");
            quyuerf[36] = opXML.QueryNodeText("num4136");
            quyuerf[37] = opXML.QueryNodeText("num4137");
            quyuerf[38] = opXML.QueryNodeText("num4138");
            quyuerf[39] = opXML.QueryNodeText("num4139");
            quyuerf[40] = opXML.QueryNodeText("num4140");

            json = "{\"quyuer1\":\"" + quyuer[1] + "\","
                          + "\"quyuer2\":\"" + quyuer[2] + "\","
                          + "\"quyuer3\":\"" + quyuer[3] + "\","
                          + "\"quyuer4\":\"" + quyuer[4] + "\","
                          + "\"quyuer5\":\"" + quyuer[5] + "\","
                          + "\"quyuer6\":\"" + quyuer[6] + "\","
                          + "\"quyuer7\":\"" + quyuer[7] + "\","
                          + "\"quyuer8\":\"" + quyuer[8] + "\","
                          + "\"quyuer9\":\"" + quyuer[9] + "\","
                          + "\"quyuer10\":\"" + quyuer[10] + "\","
                          + "\"quyuer11\":\"" + quyuer[11] + "\","
                          + "\"quyuer12\":\"" + quyuer[12] + "\","

                          + "\"quyuerf1\":\"" + quyuerf[1] + "\","
                          + "\"quyuerf2\":\"" + quyuerf[2] + "\","
                          + "\"quyuerf3\":\"" + quyuerf[3] + "\","
                          + "\"quyuerf4\":\"" + quyuerf[4] + "\","
                          + "\"quyuerf5\":\"" + quyuerf[5] + "\","
                          + "\"quyuerf6\":\"" + quyuerf[6] + "\","
                          + "\"quyuerf7\":\"" + quyuerf[7] + "\","
                          + "\"quyuerf8\":\"" + quyuerf[8] + "\","
                          + "\"quyuerf9\":\"" + quyuerf[9] + "\","
                          + "\"quyuerf10\":\"" + quyuerf[10] + "\","
                          + "\"quyuerf11\":\"" + quyuerf[11] + "\","
                          + "\"quyuerf12\":\"" + quyuerf[12] + "\","
                          + "\"quyuerf13\":\"" + quyuerf[13] + "\","
                          + "\"quyuerf14\":\"" + quyuerf[14] + "\","
                          + "\"quyuerf15\":\"" + quyuerf[15] + "\","
                          + "\"quyuerf16\":\"" + quyuerf[16] + "\","
                          + "\"quyuerf17\":\"" + quyuerf[17] + "\","
                          + "\"quyuerf18\":\"" + quyuerf[18] + "\","
                          + "\"quyuerf19\":\"" + quyuerf[19] + "\","
                          + "\"quyuerf20\":\"" + quyuerf[20] + "\","
                          + "\"quyuerf21\":\"" + quyuerf[21] + "\","
                          + "\"quyuerf22\":\"" + quyuerf[22] + "\","
                          + "\"quyuerf23\":\"" + quyuerf[23] + "\","
                          + "\"quyuerf24\":\"" + quyuerf[24] + "\","
                          + "\"quyuerf25\":\"" + quyuerf[25] + "\","
                          + "\"quyuerf26\":\"" + quyuerf[26] + "\","
                          + "\"quyuerf27\":\"" + quyuerf[27] + "\","
                          + "\"quyuerf28\":\"" + quyuerf[28] + "\","
                          + "\"quyuerf29\":\"" + quyuerf[29] + "\","
                          + "\"quyuerf30\":\"" + quyuerf[30] + "\","
                          + "\"quyuerf31\":\"" + quyuerf[31] + "\","
                          + "\"quyuerf32\":\"" + quyuerf[32] + "\","
                          + "\"quyuerf33\":\"" + quyuerf[33] + "\","
                          + "\"quyuerf34\":\"" + quyuerf[34] + "\","
                          + "\"quyuerf35\":\"" + quyuerf[35] + "\","
                          + "\"quyuerf36\":\"" + quyuerf[36] + "\","
                          + "\"quyuerf37\":\"" + quyuerf[37] + "\","
                          + "\"quyuerf38\":\"" + quyuerf[38] + "\","
                          + "\"quyuerf39\":\"" + quyuerf[39] + "\","
                          + "\"quyuerf40\":\"" + quyuerf[40] + "\"}";
            return Content(json);

        }
        //区域二写
        public ActionResult postData2()
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
                opXML.ModifyNode("num1401", Request.Form["quyuer1"]);
                opXML.ModifyNode("num1402", Request.Form["quyuer2"]);
                opXML.ModifyNode("num1403", Request.Form["quyuer3"]);
                opXML.ModifyNode("num1404", Request.Form["quyuer4"]);
                opXML.ModifyNode("num1405", Request.Form["quyuer5"]);
                opXML.ModifyNode("num1406", Request.Form["quyuer6"]);
                opXML.ModifyNode("num1407", Request.Form["quyuer7"]);
                opXML.ModifyNode("num1408", Request.Form["quyuer8"]);
                opXML.ModifyNode("num1409", Request.Form["quyuer9"]);
                opXML.ModifyNode("num1410", Request.Form["quyuer10"]);
                opXML.ModifyNode("num1411", Request.Form["quyuer11"]);
                opXML.ModifyNode("num1412", Request.Form["quyuer12"]);

                opXML.ModifyNode("num4101", Request.Form["quyuerf1"]);
                opXML.ModifyNode("num4102", Request.Form["quyuerf2"]);
                opXML.ModifyNode("num4103", Request.Form["quyuerf3"]);
                opXML.ModifyNode("num4104", Request.Form["quyuerf4"]);
                opXML.ModifyNode("num4105", Request.Form["quyuerf5"]);
                opXML.ModifyNode("num4106", Request.Form["quyuerf6"]);
                opXML.ModifyNode("num4107", Request.Form["quyuerf7"]);
                opXML.ModifyNode("num4108", Request.Form["quyuerf8"]);
                opXML.ModifyNode("num4109", Request.Form["quyuerf9"]);
                opXML.ModifyNode("num4110", Request.Form["quyuerf10"]);
                opXML.ModifyNode("num4111", Request.Form["quyuerf11"]);
                opXML.ModifyNode("num4112", Request.Form["quyuerf12"]);
                opXML.ModifyNode("num4113", Request.Form["quyuerf13"]);
                opXML.ModifyNode("num4114", Request.Form["quyuerf14"]);
                opXML.ModifyNode("num4115", Request.Form["quyuerf15"]);
                opXML.ModifyNode("num4116", Request.Form["quyuerf16"]);
                opXML.ModifyNode("num4117", Request.Form["quyuerf17"]);
                opXML.ModifyNode("num4118", Request.Form["quyuerf18"]);
                opXML.ModifyNode("num4119", Request.Form["quyuerf19"]);
                opXML.ModifyNode("num4120", Request.Form["quyuerf20"]);
                opXML.ModifyNode("num4121", Request.Form["quyuerf21"]);
                opXML.ModifyNode("num4122", Request.Form["quyuerf22"]);
                opXML.ModifyNode("num4123", Request.Form["quyuerf23"]);
                opXML.ModifyNode("num4124", Request.Form["quyuerf24"]);
                opXML.ModifyNode("num4125", Request.Form["quyuerf25"]);
                opXML.ModifyNode("num4126", Request.Form["quyuerf26"]);
                opXML.ModifyNode("num4127", Request.Form["quyuerf27"]);
                opXML.ModifyNode("num4128", Request.Form["quyuerf28"]);
                opXML.ModifyNode("num4129", Request.Form["quyuerf29"]);
                opXML.ModifyNode("num4130", Request.Form["quyuerf30"]);
                opXML.ModifyNode("num4131", Request.Form["quyuerf31"]);
                opXML.ModifyNode("num4132", Request.Form["quyuerf32"]);
                opXML.ModifyNode("num4133", Request.Form["quyuerf33"]);
                opXML.ModifyNode("num4134", Request.Form["quyuerf34"]);
                opXML.ModifyNode("num4135", Request.Form["quyuerf35"]);
                opXML.ModifyNode("num4136", Request.Form["quyuerf36"]);
                opXML.ModifyNode("num4137", Request.Form["quyuerf37"]);
                opXML.ModifyNode("num4138", Request.Form["quyuerf38"]);
                opXML.ModifyNode("num4139", Request.Form["quyuerf39"]);
                opXML.ModifyNode("num4140", Request.Form["quyuerf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //区域三读
        public ActionResult SendData3()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] quyusan = new string[20];
            string[] quyusanf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            quyusan[1] = opXML.QueryNodeText("num2601");
            quyusan[2] = opXML.QueryNodeText("num2602");
            quyusan[3] = opXML.QueryNodeText("num2603");
            quyusan[4] = opXML.QueryNodeText("num2604");
            quyusan[5] = opXML.QueryNodeText("num2605");
            quyusan[6] = opXML.QueryNodeText("num2606");
            quyusan[7] = opXML.QueryNodeText("num2607");
            quyusan[8] = opXML.QueryNodeText("num2608");
            quyusan[9] = opXML.QueryNodeText("num2609");
            quyusan[10] = opXML.QueryNodeText("num2610");
            quyusan[11] = opXML.QueryNodeText("num2611");
            quyusan[12] = opXML.QueryNodeText("num2612");

            quyusanf[1] = opXML.QueryNodeText("num4201");
            quyusanf[2] = opXML.QueryNodeText("num4202");
            quyusanf[3] = opXML.QueryNodeText("num4203");
            quyusanf[4] = opXML.QueryNodeText("num4204");
            quyusanf[5] = opXML.QueryNodeText("num4205");
            quyusanf[6] = opXML.QueryNodeText("num4206");
            quyusanf[7] = opXML.QueryNodeText("num4207");
            quyusanf[8] = opXML.QueryNodeText("num4208");
            quyusanf[9] = opXML.QueryNodeText("num4209");
            quyusanf[10] = opXML.QueryNodeText("num4210");
            quyusanf[11] = opXML.QueryNodeText("num4211");
            quyusanf[12] = opXML.QueryNodeText("num4212");
            quyusanf[13] = opXML.QueryNodeText("num4213");
            quyusanf[14] = opXML.QueryNodeText("num4214");
            quyusanf[15] = opXML.QueryNodeText("num4215");
            quyusanf[16] = opXML.QueryNodeText("num4216");
            quyusanf[17] = opXML.QueryNodeText("num4217");
            quyusanf[18] = opXML.QueryNodeText("num4218");
            quyusanf[19] = opXML.QueryNodeText("num4219");
            quyusanf[20] = opXML.QueryNodeText("num4220");
            quyusanf[21] = opXML.QueryNodeText("num4221");
            quyusanf[22] = opXML.QueryNodeText("num4222");
            quyusanf[23] = opXML.QueryNodeText("num4223");
            quyusanf[24] = opXML.QueryNodeText("num4224");
            quyusanf[25] = opXML.QueryNodeText("num4225");
            quyusanf[26] = opXML.QueryNodeText("num4226");
            quyusanf[27] = opXML.QueryNodeText("num4227");
            quyusanf[28] = opXML.QueryNodeText("num4228");
            quyusanf[29] = opXML.QueryNodeText("num4229");
            quyusanf[30] = opXML.QueryNodeText("num4230");
            quyusanf[31] = opXML.QueryNodeText("num4231");
            quyusanf[32] = opXML.QueryNodeText("num4232");
            quyusanf[33] = opXML.QueryNodeText("num4233");
            quyusanf[34] = opXML.QueryNodeText("num4234");
            quyusanf[35] = opXML.QueryNodeText("num4235");
            quyusanf[36] = opXML.QueryNodeText("num4236");
            quyusanf[37] = opXML.QueryNodeText("num4237");
            quyusanf[38] = opXML.QueryNodeText("num4238");
            quyusanf[39] = opXML.QueryNodeText("num4239");
            quyusanf[40] = opXML.QueryNodeText("num4240");

            json = "{\"quyusan1\":\"" + quyusan[1] + "\","
                          + "\"quyusan2\":\"" + quyusan[2] + "\","
                          + "\"quyusan3\":\"" + quyusan[3] + "\","
                          + "\"quyusan4\":\"" + quyusan[4] + "\","
                          + "\"quyusan5\":\"" + quyusan[5] + "\","
                          + "\"quyusan6\":\"" + quyusan[6] + "\","
                          + "\"quyusan7\":\"" + quyusan[7] + "\","
                          + "\"quyusan8\":\"" + quyusan[8] + "\","
                          + "\"quyusan9\":\"" + quyusan[9] + "\","
                          + "\"quyusan10\":\"" + quyusan[10] + "\","
                          + "\"quyusan11\":\"" + quyusan[11] + "\","
                          + "\"quyusan12\":\"" + quyusan[12] + "\","

                          + "\"quyusanf1\":\"" + quyusanf[1] + "\","
                          + "\"quyusanf2\":\"" + quyusanf[2] + "\","
                          + "\"quyusanf3\":\"" + quyusanf[3] + "\","
                          + "\"quyusanf4\":\"" + quyusanf[4] + "\","
                          + "\"quyusanf5\":\"" + quyusanf[5] + "\","
                          + "\"quyusanf6\":\"" + quyusanf[6] + "\","
                          + "\"quyusanf7\":\"" + quyusanf[7] + "\","
                          + "\"quyusanf8\":\"" + quyusanf[8] + "\","
                          + "\"quyusanf9\":\"" + quyusanf[9] + "\","
                          + "\"quyusanf10\":\"" + quyusanf[10] + "\","
                          + "\"quyusanf11\":\"" + quyusanf[11] + "\","
                          + "\"quyusanf12\":\"" + quyusanf[12] + "\","
                          + "\"quyusanf13\":\"" + quyusanf[13] + "\","
                          + "\"quyusanf14\":\"" + quyusanf[14] + "\","
                          + "\"quyusanf15\":\"" + quyusanf[15] + "\","
                          + "\"quyusanf16\":\"" + quyusanf[16] + "\","
                          + "\"quyusanf17\":\"" + quyusanf[17] + "\","
                          + "\"quyusanf18\":\"" + quyusanf[18] + "\","
                          + "\"quyusanf19\":\"" + quyusanf[19] + "\","
                          + "\"quyusanf20\":\"" + quyusanf[20] + "\","
                          + "\"quyusanf21\":\"" + quyusanf[21] + "\","
                          + "\"quyusanf22\":\"" + quyusanf[22] + "\","
                          + "\"quyusanf23\":\"" + quyusanf[23] + "\","
                          + "\"quyusanf24\":\"" + quyusanf[24] + "\","
                          + "\"quyusanf25\":\"" + quyusanf[25] + "\","
                          + "\"quyusanf26\":\"" + quyusanf[26] + "\","
                          + "\"quyusanf27\":\"" + quyusanf[27] + "\","
                          + "\"quyusanf28\":\"" + quyusanf[28] + "\","
                          + "\"quyusanf29\":\"" + quyusanf[29] + "\","
                          + "\"quyusanf30\":\"" + quyusanf[30] + "\","
                          + "\"quyusanf31\":\"" + quyusanf[31] + "\","
                          + "\"quyusanf32\":\"" + quyusanf[32] + "\","
                          + "\"quyusanf33\":\"" + quyusanf[33] + "\","
                          + "\"quyusanf34\":\"" + quyusanf[34] + "\","
                          + "\"quyusanf35\":\"" + quyusanf[35] + "\","
                          + "\"quyusanf36\":\"" + quyusanf[36] + "\","
                          + "\"quyusanf37\":\"" + quyusanf[37] + "\","
                          + "\"quyusanf38\":\"" + quyusanf[38] + "\","
                          + "\"quyusanf39\":\"" + quyusanf[39] + "\","
                          + "\"quyusanf40\":\"" + quyusanf[40] + "\"}";
            return Content(json);


        }
        //区域三写
        public ActionResult postData3()
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
                opXML.ModifyNode("num2601", Request.Form["quyusan1"]);
                opXML.ModifyNode("num2602", Request.Form["quyusan2"]);
                opXML.ModifyNode("num2603", Request.Form["quyusan3"]);
                opXML.ModifyNode("num2604", Request.Form["quyusan4"]);
                opXML.ModifyNode("num2605", Request.Form["quyusan5"]);
                opXML.ModifyNode("num2606", Request.Form["quyusan6"]);
                opXML.ModifyNode("num2607", Request.Form["quyusan7"]);
                opXML.ModifyNode("num2608", Request.Form["quyusan8"]);
                opXML.ModifyNode("num2609", Request.Form["quyusan9"]);
                opXML.ModifyNode("num2610", Request.Form["quyusan10"]);
                opXML.ModifyNode("num2611", Request.Form["quyusan11"]);
                opXML.ModifyNode("num2612", Request.Form["quyusan12"]);

                opXML.ModifyNode("num4201", Request.Form["quyusanf1"]);
                opXML.ModifyNode("num4202", Request.Form["quyusanf2"]);
                opXML.ModifyNode("num4203", Request.Form["quyusanf3"]);
                opXML.ModifyNode("num4204", Request.Form["quyusanf4"]);
                opXML.ModifyNode("num4205", Request.Form["quyusanf5"]);
                opXML.ModifyNode("num4206", Request.Form["quyusanf6"]);
                opXML.ModifyNode("num4207", Request.Form["quyusanf7"]);
                opXML.ModifyNode("num4208", Request.Form["quyusanf8"]);
                opXML.ModifyNode("num4209", Request.Form["quyusanf9"]);
                opXML.ModifyNode("num4210", Request.Form["quyusanf10"]);
                opXML.ModifyNode("num4211", Request.Form["quyusanf11"]);
                opXML.ModifyNode("num4212", Request.Form["quyusanf12"]);
                opXML.ModifyNode("num4213", Request.Form["quyusanf13"]);
                opXML.ModifyNode("num4214", Request.Form["quyusanf14"]);
                opXML.ModifyNode("num4215", Request.Form["quyusanf15"]);
                opXML.ModifyNode("num4216", Request.Form["quyusanf16"]);
                opXML.ModifyNode("num4217", Request.Form["quyusanf17"]);
                opXML.ModifyNode("num4218", Request.Form["quyusanf18"]);
                opXML.ModifyNode("num4219", Request.Form["quyusanf19"]);
                opXML.ModifyNode("num4220", Request.Form["quyusanf20"]);
                opXML.ModifyNode("num4221", Request.Form["quyusanf21"]);
                opXML.ModifyNode("num4222", Request.Form["quyusanf22"]);
                opXML.ModifyNode("num4223", Request.Form["quyusanf23"]);
                opXML.ModifyNode("num4224", Request.Form["quyusanf24"]);
                opXML.ModifyNode("num4225", Request.Form["quyusanf25"]);
                opXML.ModifyNode("num4226", Request.Form["quyusanf26"]);
                opXML.ModifyNode("num4227", Request.Form["quyusanf27"]);
                opXML.ModifyNode("num4228", Request.Form["quyusanf28"]);
                opXML.ModifyNode("num4229", Request.Form["quyusanf29"]);
                opXML.ModifyNode("num4230", Request.Form["quyusanf30"]);
                opXML.ModifyNode("num4231", Request.Form["quyusanf31"]);
                opXML.ModifyNode("num4232", Request.Form["quyusanf32"]);
                opXML.ModifyNode("num4233", Request.Form["quyusanf33"]);
                opXML.ModifyNode("num4234", Request.Form["quyusanf34"]);
                opXML.ModifyNode("num4235", Request.Form["quyusanf35"]);
                opXML.ModifyNode("num4236", Request.Form["quyusanf36"]);
                opXML.ModifyNode("num4237", Request.Form["quyusanf37"]);
                opXML.ModifyNode("num4238", Request.Form["quyusanf38"]);
                opXML.ModifyNode("num4239", Request.Form["quyusanf39"]);
                opXML.ModifyNode("num4240", Request.Form["quyusanf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //区域四读
        public ActionResult SendData4()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] quyusi = new string[20];
            string[] quyusif = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            quyusi[1] = opXML.QueryNodeText("num2701");
            quyusi[2] = opXML.QueryNodeText("num2702");
            quyusi[3] = opXML.QueryNodeText("num2703");
            quyusi[4] = opXML.QueryNodeText("num2704");
            quyusi[5] = opXML.QueryNodeText("num2705");
            quyusi[6] = opXML.QueryNodeText("num2706");
            quyusi[7] = opXML.QueryNodeText("num2707");
            quyusi[8] = opXML.QueryNodeText("num2708");
            quyusi[9] = opXML.QueryNodeText("num2709");
            quyusi[10] = opXML.QueryNodeText("num2710");
            quyusi[11] = opXML.QueryNodeText("num2711");
            quyusi[12] = opXML.QueryNodeText("num2712");

            quyusif[1] = opXML.QueryNodeText("num4301");
            quyusif[2] = opXML.QueryNodeText("num4302");
            quyusif[3] = opXML.QueryNodeText("num4303");
            quyusif[4] = opXML.QueryNodeText("num4304");
            quyusif[5] = opXML.QueryNodeText("num4305");
            quyusif[6] = opXML.QueryNodeText("num4306");
            quyusif[7] = opXML.QueryNodeText("num4307");
            quyusif[8] = opXML.QueryNodeText("num4308");
            quyusif[9] = opXML.QueryNodeText("num4309");
            quyusif[10] = opXML.QueryNodeText("num4310");
            quyusif[11] = opXML.QueryNodeText("num4311");
            quyusif[12] = opXML.QueryNodeText("num4312");
            quyusif[13] = opXML.QueryNodeText("num4313");
            quyusif[14] = opXML.QueryNodeText("num4314");
            quyusif[15] = opXML.QueryNodeText("num4315");
            quyusif[16] = opXML.QueryNodeText("num4316");
            quyusif[17] = opXML.QueryNodeText("num4317");
            quyusif[18] = opXML.QueryNodeText("num4318");
            quyusif[19] = opXML.QueryNodeText("num4319");
            quyusif[20] = opXML.QueryNodeText("num4320");
            quyusif[21] = opXML.QueryNodeText("num4321");
            quyusif[22] = opXML.QueryNodeText("num4322");
            quyusif[23] = opXML.QueryNodeText("num4323");
            quyusif[24] = opXML.QueryNodeText("num4324");
            quyusif[25] = opXML.QueryNodeText("num4325");
            quyusif[26] = opXML.QueryNodeText("num4326");
            quyusif[27] = opXML.QueryNodeText("num4327");
            quyusif[28] = opXML.QueryNodeText("num4328");
            quyusif[29] = opXML.QueryNodeText("num4329");
            quyusif[30] = opXML.QueryNodeText("num4330");
            quyusif[31] = opXML.QueryNodeText("num4331");
            quyusif[32] = opXML.QueryNodeText("num4332");
            quyusif[33] = opXML.QueryNodeText("num4333");
            quyusif[34] = opXML.QueryNodeText("num4334");
            quyusif[35] = opXML.QueryNodeText("num4335");
            quyusif[36] = opXML.QueryNodeText("num4336");
            quyusif[37] = opXML.QueryNodeText("num4337");
            quyusif[38] = opXML.QueryNodeText("num4338");
            quyusif[39] = opXML.QueryNodeText("num4339");
            quyusif[40] = opXML.QueryNodeText("num4340");

            json = "{\"quyusi1\":\"" + quyusi[1] + "\","
                          + "\"quyusi2\":\"" + quyusi[2] + "\","
                          + "\"quyusi3\":\"" + quyusi[3] + "\","
                          + "\"quyusi4\":\"" + quyusi[4] + "\","
                          + "\"quyusi5\":\"" + quyusi[5] + "\","
                          + "\"quyusi6\":\"" + quyusi[6] + "\","
                          + "\"quyusi7\":\"" + quyusi[7] + "\","
                          + "\"quyusi8\":\"" + quyusi[8] + "\","
                          + "\"quyusi9\":\"" + quyusi[9] + "\","
                          + "\"quyusi10\":\"" + quyusi[10] + "\","
                          + "\"quyusi11\":\"" + quyusi[11] + "\","
                          + "\"quyusi12\":\"" + quyusi[12] + "\","

                          + "\"quyusif1\":\"" + quyusif[1] + "\","
                          + "\"quyusif2\":\"" + quyusif[2] + "\","
                          + "\"quyusif3\":\"" + quyusif[3] + "\","
                          + "\"quyusif4\":\"" + quyusif[4] + "\","
                          + "\"quyusif5\":\"" + quyusif[5] + "\","
                          + "\"quyusif6\":\"" + quyusif[6] + "\","
                          + "\"quyusif7\":\"" + quyusif[7] + "\","
                          + "\"quyusif8\":\"" + quyusif[8] + "\","
                          + "\"quyusif9\":\"" + quyusif[9] + "\","
                          + "\"quyusif10\":\"" + quyusif[10] + "\","
                          + "\"quyusif11\":\"" + quyusif[11] + "\","
                          + "\"quyusif12\":\"" + quyusif[12] + "\","
                          + "\"quyusif13\":\"" + quyusif[13] + "\","
                          + "\"quyusif14\":\"" + quyusif[14] + "\","
                          + "\"quyusif15\":\"" + quyusif[15] + "\","
                          + "\"quyusif16\":\"" + quyusif[16] + "\","
                          + "\"quyusif17\":\"" + quyusif[17] + "\","
                          + "\"quyusif18\":\"" + quyusif[18] + "\","
                          + "\"quyusif19\":\"" + quyusif[19] + "\","
                          + "\"quyusif20\":\"" + quyusif[20] + "\","
                          + "\"quyusif21\":\"" + quyusif[21] + "\","
                          + "\"quyusif22\":\"" + quyusif[22] + "\","
                          + "\"quyusif23\":\"" + quyusif[23] + "\","
                          + "\"quyusif24\":\"" + quyusif[24] + "\","
                          + "\"quyusif25\":\"" + quyusif[25] + "\","
                          + "\"quyusif26\":\"" + quyusif[26] + "\","
                          + "\"quyusif27\":\"" + quyusif[27] + "\","
                          + "\"quyusif28\":\"" + quyusif[28] + "\","
                          + "\"quyusif29\":\"" + quyusif[29] + "\","
                          + "\"quyusif30\":\"" + quyusif[30] + "\","
                          + "\"quyusif31\":\"" + quyusif[31] + "\","
                          + "\"quyusif32\":\"" + quyusif[32] + "\","
                          + "\"quyusif33\":\"" + quyusif[33] + "\","
                          + "\"quyusif34\":\"" + quyusif[34] + "\","
                          + "\"quyusif35\":\"" + quyusif[35] + "\","
                          + "\"quyusif36\":\"" + quyusif[36] + "\","
                          + "\"quyusif37\":\"" + quyusif[37] + "\","
                          + "\"quyusif38\":\"" + quyusif[38] + "\","
                          + "\"quyusif39\":\"" + quyusif[39] + "\","
                          + "\"quyusif40\":\"" + quyusif[40] + "\"}";
            return Content(json);

        }
        //区域四写
        public ActionResult postData4()
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
                opXML.ModifyNode("num2701", Request.Form["quyusi1"]);
                opXML.ModifyNode("num2702", Request.Form["quyusi2"]);
                opXML.ModifyNode("num2703", Request.Form["quyusi3"]);
                opXML.ModifyNode("num2704", Request.Form["quyusi4"]);
                opXML.ModifyNode("num2705", Request.Form["quyusi5"]);
                opXML.ModifyNode("num2706", Request.Form["quyusi6"]);
                opXML.ModifyNode("num2707", Request.Form["quyusi7"]);
                opXML.ModifyNode("num2708", Request.Form["quyusi8"]);
                opXML.ModifyNode("num2709", Request.Form["quyusi9"]);
                opXML.ModifyNode("num2710", Request.Form["quyusi10"]);
                opXML.ModifyNode("num2711", Request.Form["quyusi11"]);
                opXML.ModifyNode("num2712", Request.Form["quyusi12"]);

                opXML.ModifyNode("num4301", Request.Form["quyusif1"]);
                opXML.ModifyNode("num4302", Request.Form["quyusif2"]);
                opXML.ModifyNode("num4303", Request.Form["quyusif3"]);
                opXML.ModifyNode("num4304", Request.Form["quyusif4"]);
                opXML.ModifyNode("num4305", Request.Form["quyusif5"]);
                opXML.ModifyNode("num4306", Request.Form["quyusif6"]);
                opXML.ModifyNode("num4307", Request.Form["quyusif7"]);
                opXML.ModifyNode("num4308", Request.Form["quyusif8"]);
                opXML.ModifyNode("num4309", Request.Form["quyusif9"]);
                opXML.ModifyNode("num4310", Request.Form["quyusif10"]);
                opXML.ModifyNode("num4311", Request.Form["quyusif11"]);
                opXML.ModifyNode("num4312", Request.Form["quyusif12"]);
                opXML.ModifyNode("num4313", Request.Form["quyusif13"]);
                opXML.ModifyNode("num4314", Request.Form["quyusif14"]);
                opXML.ModifyNode("num4315", Request.Form["quyusif15"]);
                opXML.ModifyNode("num4316", Request.Form["quyusif16"]);
                opXML.ModifyNode("num4317", Request.Form["quyusif17"]);
                opXML.ModifyNode("num4318", Request.Form["quyusif18"]);
                opXML.ModifyNode("num4319", Request.Form["quyusif19"]);
                opXML.ModifyNode("num4320", Request.Form["quyusif20"]);
                opXML.ModifyNode("num4321", Request.Form["quyusif21"]);
                opXML.ModifyNode("num4322", Request.Form["quyusif22"]);
                opXML.ModifyNode("num4323", Request.Form["quyusif23"]);
                opXML.ModifyNode("num4324", Request.Form["quyusif24"]);
                opXML.ModifyNode("num4325", Request.Form["quyusif25"]);
                opXML.ModifyNode("num4326", Request.Form["quyusif26"]);
                opXML.ModifyNode("num4327", Request.Form["quyusif27"]);
                opXML.ModifyNode("num4328", Request.Form["quyusif28"]);
                opXML.ModifyNode("num4329", Request.Form["quyusif29"]);
                opXML.ModifyNode("num4330", Request.Form["quyusif30"]);
                opXML.ModifyNode("num4331", Request.Form["quyusif31"]);
                opXML.ModifyNode("num4332", Request.Form["quyusif32"]);
                opXML.ModifyNode("num4333", Request.Form["quyusif33"]);
                opXML.ModifyNode("num4334", Request.Form["quyusif34"]);
                opXML.ModifyNode("num4335", Request.Form["quyusif35"]);
                opXML.ModifyNode("num4336", Request.Form["quyusif36"]);
                opXML.ModifyNode("num4337", Request.Form["quyusif37"]);
                opXML.ModifyNode("num4338", Request.Form["quyusif38"]);
                opXML.ModifyNode("num4339", Request.Form["quyusif39"]);
                opXML.ModifyNode("num4340", Request.Form["quyusif40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //区域五读
        public ActionResult SendData5()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] quyuwu = new string[20];
            string[] quyuwuf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            quyuwu[1] = opXML.QueryNodeText("num2801");
            quyuwu[2] = opXML.QueryNodeText("num2802");
            quyuwu[3] = opXML.QueryNodeText("num2803");
            quyuwu[4] = opXML.QueryNodeText("num2804");
            quyuwu[5] = opXML.QueryNodeText("num2805");
            quyuwu[6] = opXML.QueryNodeText("num2806");
            quyuwu[7] = opXML.QueryNodeText("num2807");
            quyuwu[8] = opXML.QueryNodeText("num2808");
            quyuwu[9] = opXML.QueryNodeText("num2809");
            quyuwu[10] = opXML.QueryNodeText("num2810");
            quyuwu[11] = opXML.QueryNodeText("num2811");
            quyuwu[12] = opXML.QueryNodeText("num2812");

            quyuwuf[1] = opXML.QueryNodeText("num4401");
            quyuwuf[2] = opXML.QueryNodeText("num4402");
            quyuwuf[3] = opXML.QueryNodeText("num4403");
            quyuwuf[4] = opXML.QueryNodeText("num4404");
            quyuwuf[5] = opXML.QueryNodeText("num4405");
            quyuwuf[6] = opXML.QueryNodeText("num4406");
            quyuwuf[7] = opXML.QueryNodeText("num4407");
            quyuwuf[8] = opXML.QueryNodeText("num4408");
            quyuwuf[9] = opXML.QueryNodeText("num4409");
            quyuwuf[10] = opXML.QueryNodeText("num4410");
            quyuwuf[11] = opXML.QueryNodeText("num4411");
            quyuwuf[12] = opXML.QueryNodeText("num4412");
            quyuwuf[13] = opXML.QueryNodeText("num4413");
            quyuwuf[14] = opXML.QueryNodeText("num4414");
            quyuwuf[15] = opXML.QueryNodeText("num4415");
            quyuwuf[16] = opXML.QueryNodeText("num4416");
            quyuwuf[17] = opXML.QueryNodeText("num4417");
            quyuwuf[18] = opXML.QueryNodeText("num4418");
            quyuwuf[19] = opXML.QueryNodeText("num4419");
            quyuwuf[20] = opXML.QueryNodeText("num4420");
            quyuwuf[21] = opXML.QueryNodeText("num4421");
            quyuwuf[22] = opXML.QueryNodeText("num4422");
            quyuwuf[23] = opXML.QueryNodeText("num4423");
            quyuwuf[24] = opXML.QueryNodeText("num4424");
            quyuwuf[25] = opXML.QueryNodeText("num4425");
            quyuwuf[26] = opXML.QueryNodeText("num4426");
            quyuwuf[27] = opXML.QueryNodeText("num4427");
            quyuwuf[28] = opXML.QueryNodeText("num4428");
            quyuwuf[29] = opXML.QueryNodeText("num4429");
            quyuwuf[30] = opXML.QueryNodeText("num4430");
            quyuwuf[31] = opXML.QueryNodeText("num4431");
            quyuwuf[32] = opXML.QueryNodeText("num4432");
            quyuwuf[33] = opXML.QueryNodeText("num4433");
            quyuwuf[34] = opXML.QueryNodeText("num4434");
            quyuwuf[35] = opXML.QueryNodeText("num4435");
            quyuwuf[36] = opXML.QueryNodeText("num4436");
            quyuwuf[37] = opXML.QueryNodeText("num4437");
            quyuwuf[38] = opXML.QueryNodeText("num4438");
            quyuwuf[39] = opXML.QueryNodeText("num4439");
            quyuwuf[40] = opXML.QueryNodeText("num4440");

            json = "{\"quyuwu1\":\"" + quyuwu[1] + "\","
                          + "\"quyuwu2\":\"" + quyuwu[2] + "\","
                          + "\"quyuwu3\":\"" + quyuwu[3] + "\","
                          + "\"quyuwu4\":\"" + quyuwu[4] + "\","
                          + "\"quyuwu5\":\"" + quyuwu[5] + "\","
                          + "\"quyuwu6\":\"" + quyuwu[6] + "\","
                          + "\"quyuwu7\":\"" + quyuwu[7] + "\","
                          + "\"quyuwu8\":\"" + quyuwu[8] + "\","
                          + "\"quyuwu9\":\"" + quyuwu[9] + "\","
                          + "\"quyuwu10\":\"" + quyuwu[10] + "\","
                          + "\"quyuwu11\":\"" + quyuwu[11] + "\","
                          + "\"quyuwu12\":\"" + quyuwu[12] + "\","

                          + "\"quyuwuf1\":\"" + quyuwuf[1] + "\","
                          + "\"quyuwuf2\":\"" + quyuwuf[2] + "\","
                          + "\"quyuwuf3\":\"" + quyuwuf[3] + "\","
                          + "\"quyuwuf4\":\"" + quyuwuf[4] + "\","
                          + "\"quyuwuf5\":\"" + quyuwuf[5] + "\","
                          + "\"quyuwuf6\":\"" + quyuwuf[6] + "\","
                          + "\"quyuwuf7\":\"" + quyuwuf[7] + "\","
                          + "\"quyuwuf8\":\"" + quyuwuf[8] + "\","
                          + "\"quyuwuf9\":\"" + quyuwuf[9] + "\","
                          + "\"quyuwuf10\":\"" + quyuwuf[10] + "\","
                          + "\"quyuwuf11\":\"" + quyuwuf[11] + "\","
                          + "\"quyuwuf12\":\"" + quyuwuf[12] + "\","
                          + "\"quyuwuf13\":\"" + quyuwuf[13] + "\","
                          + "\"quyuwuf14\":\"" + quyuwuf[14] + "\","
                          + "\"quyuwuf15\":\"" + quyuwuf[15] + "\","
                          + "\"quyuwuf16\":\"" + quyuwuf[16] + "\","
                          + "\"quyuwuf17\":\"" + quyuwuf[17] + "\","
                          + "\"quyuwuf18\":\"" + quyuwuf[18] + "\","
                          + "\"quyuwuf19\":\"" + quyuwuf[19] + "\","
                          + "\"quyuwuf20\":\"" + quyuwuf[20] + "\","
                          + "\"quyuwuf21\":\"" + quyuwuf[21] + "\","
                          + "\"quyuwuf22\":\"" + quyuwuf[22] + "\","
                          + "\"quyuwuf23\":\"" + quyuwuf[23] + "\","
                          + "\"quyuwuf24\":\"" + quyuwuf[24] + "\","
                          + "\"quyuwuf25\":\"" + quyuwuf[25] + "\","
                          + "\"quyuwuf26\":\"" + quyuwuf[26] + "\","
                          + "\"quyuwuf27\":\"" + quyuwuf[27] + "\","
                          + "\"quyuwuf28\":\"" + quyuwuf[28] + "\","
                          + "\"quyuwuf29\":\"" + quyuwuf[29] + "\","
                          + "\"quyuwuf30\":\"" + quyuwuf[30] + "\","
                          + "\"quyuwuf31\":\"" + quyuwuf[31] + "\","
                          + "\"quyuwuf32\":\"" + quyuwuf[32] + "\","
                          + "\"quyuwuf33\":\"" + quyuwuf[33] + "\","
                          + "\"quyuwuf34\":\"" + quyuwuf[34] + "\","
                          + "\"quyuwuf35\":\"" + quyuwuf[35] + "\","
                          + "\"quyuwuf36\":\"" + quyuwuf[36] + "\","
                          + "\"quyuwuf37\":\"" + quyuwuf[37] + "\","
                          + "\"quyuwuf38\":\"" + quyuwuf[38] + "\","
                          + "\"quyuwuf39\":\"" + quyuwuf[39] + "\","
                          + "\"quyuwuf40\":\"" + quyuwuf[40] + "\"}";
            return Content(json);
        }
        //区域五写
        public ActionResult postData5()
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
                opXML.ModifyNode("num2801", Request.Form["quyuwu1"]);
                opXML.ModifyNode("num2802", Request.Form["quyuwu2"]);
                opXML.ModifyNode("num2803", Request.Form["quyuwu3"]);
                opXML.ModifyNode("num2804", Request.Form["quyuwu4"]);
                opXML.ModifyNode("num2805", Request.Form["quyuwu5"]);
                opXML.ModifyNode("num2806", Request.Form["quyuwu6"]);
                opXML.ModifyNode("num2807", Request.Form["quyuwu7"]);
                opXML.ModifyNode("num2808", Request.Form["quyuwu8"]);
                opXML.ModifyNode("num2809", Request.Form["quyuwu9"]);
                opXML.ModifyNode("num2810", Request.Form["quyuwu10"]);
                opXML.ModifyNode("num2811", Request.Form["quyuwu11"]);
                opXML.ModifyNode("num2812", Request.Form["quyuwu12"]);

                opXML.ModifyNode("num4401", Request.Form["quyuwuf1"]);
                opXML.ModifyNode("num4402", Request.Form["quyuwuf2"]);
                opXML.ModifyNode("num4403", Request.Form["quyuwuf3"]);
                opXML.ModifyNode("num4404", Request.Form["quyuwuf4"]);
                opXML.ModifyNode("num4405", Request.Form["quyuwuf5"]);
                opXML.ModifyNode("num4406", Request.Form["quyuwuf6"]);
                opXML.ModifyNode("num4407", Request.Form["quyuwuf7"]);
                opXML.ModifyNode("num4408", Request.Form["quyuwuf8"]);
                opXML.ModifyNode("num4409", Request.Form["quyuwuf9"]);
                opXML.ModifyNode("num4410", Request.Form["quyuwuf10"]);
                opXML.ModifyNode("num4411", Request.Form["quyuwuf11"]);
                opXML.ModifyNode("num4412", Request.Form["quyuwuf12"]);
                opXML.ModifyNode("num4413", Request.Form["quyuwuf13"]);
                opXML.ModifyNode("num4414", Request.Form["quyuwuf14"]);
                opXML.ModifyNode("num4415", Request.Form["quyuwuf15"]);
                opXML.ModifyNode("num4416", Request.Form["quyuwuf16"]);
                opXML.ModifyNode("num4417", Request.Form["quyuwuf17"]);
                opXML.ModifyNode("num4418", Request.Form["quyuwuf18"]);
                opXML.ModifyNode("num4419", Request.Form["quyuwuf19"]);
                opXML.ModifyNode("num4420", Request.Form["quyuwuf20"]);
                opXML.ModifyNode("num4421", Request.Form["quyuwuf21"]);
                opXML.ModifyNode("num4422", Request.Form["quyuwuf22"]);
                opXML.ModifyNode("num4423", Request.Form["quyuwuf23"]);
                opXML.ModifyNode("num4424", Request.Form["quyuwuf24"]);
                opXML.ModifyNode("num4425", Request.Form["quyuwuf25"]);
                opXML.ModifyNode("num4426", Request.Form["quyuwuf26"]);
                opXML.ModifyNode("num4427", Request.Form["quyuwuf27"]);
                opXML.ModifyNode("num4428", Request.Form["quyuwuf28"]);
                opXML.ModifyNode("num4429", Request.Form["quyuwuf29"]);
                opXML.ModifyNode("num4430", Request.Form["quyuwuf30"]);
                opXML.ModifyNode("num4431", Request.Form["quyuwuf31"]);
                opXML.ModifyNode("num4432", Request.Form["quyuwuf32"]);
                opXML.ModifyNode("num4433", Request.Form["quyuwuf33"]);
                opXML.ModifyNode("num4434", Request.Form["quyuwuf34"]);
                opXML.ModifyNode("num4435", Request.Form["quyuwuf35"]);
                opXML.ModifyNode("num4436", Request.Form["quyuwuf36"]);
                opXML.ModifyNode("num4437", Request.Form["quyuwuf37"]);
                opXML.ModifyNode("num4438", Request.Form["quyuwuf38"]);
                opXML.ModifyNode("num4439", Request.Form["quyuwuf39"]);
                opXML.ModifyNode("num4440", Request.Form["quyuwuf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //灰度1读
        public ActionResult SendDataHD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] huidu = new string[20];
            string[] huiduf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            huidu[1] = opXML.QueryNodeText("num2301");
            huidu[2] = opXML.QueryNodeText("num2302");
            huidu[3] = opXML.QueryNodeText("num2303");
            huidu[4] = opXML.QueryNodeText("num2304");
            huidu[5] = opXML.QueryNodeText("num2305");
            huidu[6] = opXML.QueryNodeText("num2306");
            huidu[7] = opXML.QueryNodeText("num2307");
            huidu[8] = opXML.QueryNodeText("num2308");
            huidu[9] = opXML.QueryNodeText("num2309");
            huidu[10] = opXML.QueryNodeText("num2310");
            huidu[11] = opXML.QueryNodeText("num2311");
            huidu[12] = opXML.QueryNodeText("num2312");

            huiduf[1] = opXML.QueryNodeText("num4701");
            huiduf[2] = opXML.QueryNodeText("num4702");
            huiduf[3] = opXML.QueryNodeText("num4703");
            huiduf[4] = opXML.QueryNodeText("num4704");
            huiduf[5] = opXML.QueryNodeText("num4705");
            huiduf[6] = opXML.QueryNodeText("num4706");
            huiduf[7] = opXML.QueryNodeText("num4707");
            huiduf[8] = opXML.QueryNodeText("num4708");
            huiduf[9] = opXML.QueryNodeText("num4709");
            huiduf[10] = opXML.QueryNodeText("num4710");
            huiduf[11] = opXML.QueryNodeText("num4711");
            huiduf[12] = opXML.QueryNodeText("num4712");
            huiduf[13] = opXML.QueryNodeText("num4713");
            huiduf[14] = opXML.QueryNodeText("num4714");
            huiduf[15] = opXML.QueryNodeText("num4715");
            huiduf[16] = opXML.QueryNodeText("num4716");
            huiduf[17] = opXML.QueryNodeText("num4717");
            huiduf[18] = opXML.QueryNodeText("num4718");
            huiduf[19] = opXML.QueryNodeText("num4719");
            huiduf[20] = opXML.QueryNodeText("num4720");
            huiduf[21] = opXML.QueryNodeText("num4721");
            huiduf[22] = opXML.QueryNodeText("num4722");
            huiduf[23] = opXML.QueryNodeText("num4723");
            huiduf[24] = opXML.QueryNodeText("num4724");
            huiduf[25] = opXML.QueryNodeText("num4725");
            huiduf[26] = opXML.QueryNodeText("num4726");
            huiduf[27] = opXML.QueryNodeText("num4727");
            huiduf[28] = opXML.QueryNodeText("num4728");
            huiduf[29] = opXML.QueryNodeText("num4729");
            huiduf[30] = opXML.QueryNodeText("num4730");
            huiduf[31] = opXML.QueryNodeText("num4731");
            huiduf[32] = opXML.QueryNodeText("num4732");
            huiduf[33] = opXML.QueryNodeText("num4733");
            huiduf[34] = opXML.QueryNodeText("num4734");
            huiduf[35] = opXML.QueryNodeText("num4735");
            huiduf[36] = opXML.QueryNodeText("num4736");
            huiduf[37] = opXML.QueryNodeText("num4737");
            huiduf[38] = opXML.QueryNodeText("num4738");
            huiduf[39] = opXML.QueryNodeText("num4739");
            huiduf[40] = opXML.QueryNodeText("num4740");

            json = "{\"huidu1\":\"" + huidu[1] + "\","
                          + "\"huidu2\":\"" + huidu[2] + "\","
                          + "\"huidu3\":\"" + huidu[3] + "\","
                          + "\"huidu4\":\"" + huidu[4] + "\","
                          + "\"huidu5\":\"" + huidu[5] + "\","
                          + "\"huidu6\":\"" + huidu[6] + "\","
                          + "\"huidu7\":\"" + huidu[7] + "\","
                          + "\"huidu8\":\"" + huidu[8] + "\","
                          + "\"huidu9\":\"" + huidu[9] + "\","
                          + "\"huidu10\":\"" + huidu[10] + "\","
                          + "\"huidu11\":\"" + huidu[11] + "\","
                          + "\"huidu12\":\"" + huidu[12] + "\","

                          + "\"huiduf1\":\"" + huiduf[1] + "\","
                          + "\"huiduf2\":\"" + huiduf[2] + "\","
                          + "\"huiduf3\":\"" + huiduf[3] + "\","
                          + "\"huiduf4\":\"" + huiduf[4] + "\","
                          + "\"huiduf5\":\"" + huiduf[5] + "\","
                          + "\"huiduf6\":\"" + huiduf[6] + "\","
                          + "\"huiduf7\":\"" + huiduf[7] + "\","
                          + "\"huiduf8\":\"" + huiduf[8] + "\","
                          + "\"huiduf9\":\"" + huiduf[9] + "\","
                          + "\"huiduf10\":\"" + huiduf[10] + "\","
                          + "\"huiduf11\":\"" + huiduf[11] + "\","
                          + "\"huiduf12\":\"" + huiduf[12] + "\","
                          + "\"huiduf13\":\"" + huiduf[13] + "\","
                          + "\"huiduf14\":\"" + huiduf[14] + "\","
                          + "\"huiduf15\":\"" + huiduf[15] + "\","
                          + "\"huiduf16\":\"" + huiduf[16] + "\","
                          + "\"huiduf17\":\"" + huiduf[17] + "\","
                          + "\"huiduf18\":\"" + huiduf[18] + "\","
                          + "\"huiduf19\":\"" + huiduf[19] + "\","
                          + "\"huiduf20\":\"" + huiduf[20] + "\","
                          + "\"huiduf21\":\"" + huiduf[21] + "\","
                          + "\"huiduf22\":\"" + huiduf[22] + "\","
                          + "\"huiduf23\":\"" + huiduf[23] + "\","
                          + "\"huiduf24\":\"" + huiduf[24] + "\","
                          + "\"huiduf25\":\"" + huiduf[25] + "\","
                          + "\"huiduf26\":\"" + huiduf[26] + "\","
                          + "\"huiduf27\":\"" + huiduf[27] + "\","
                          + "\"huiduf28\":\"" + huiduf[28] + "\","
                          + "\"huiduf29\":\"" + huiduf[29] + "\","
                          + "\"huiduf30\":\"" + huiduf[30] + "\","
                          + "\"huiduf31\":\"" + huiduf[31] + "\","
                          + "\"huiduf32\":\"" + huiduf[32] + "\","
                          + "\"huiduf33\":\"" + huiduf[33] + "\","
                          + "\"huiduf34\":\"" + huiduf[34] + "\","
                          + "\"huiduf35\":\"" + huiduf[35] + "\","
                          + "\"huiduf36\":\"" + huiduf[36] + "\","
                          + "\"huiduf37\":\"" + huiduf[37] + "\","
                          + "\"huiduf38\":\"" + huiduf[38] + "\","
                          + "\"huiduf39\":\"" + huiduf[39] + "\","
                          + "\"huiduf40\":\"" + huiduf[40] + "\"}";
            return Content(json);
        }
        //灰度1写
        public ActionResult postDataHD()
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
                opXML.ModifyNode("num2301", Request.Form["huidu1"]);
                opXML.ModifyNode("num2302", Request.Form["huidu2"]);
                opXML.ModifyNode("num2303", Request.Form["huidu3"]);
                opXML.ModifyNode("num2304", Request.Form["huidu4"]);
                opXML.ModifyNode("num2305", Request.Form["huidu5"]);
                opXML.ModifyNode("num2306", Request.Form["huidu6"]);
                opXML.ModifyNode("num2307", Request.Form["huidu7"]);
                opXML.ModifyNode("num2308", Request.Form["huidu8"]);
                opXML.ModifyNode("num2309", Request.Form["huidu9"]);
                opXML.ModifyNode("num2310", Request.Form["huidu10"]);
                opXML.ModifyNode("num2311", Request.Form["huidu11"]);
                opXML.ModifyNode("num2312", Request.Form["huidu12"]);

                opXML.ModifyNode("num4701", Request.Form["huiduf1"]);
                opXML.ModifyNode("num4702", Request.Form["huiduf2"]);
                opXML.ModifyNode("num4703", Request.Form["huiduf3"]);
                opXML.ModifyNode("num4704", Request.Form["huiduf4"]);
                opXML.ModifyNode("num4705", Request.Form["huiduf5"]);
                opXML.ModifyNode("num4706", Request.Form["huiduf6"]);
                opXML.ModifyNode("num4707", Request.Form["huiduf7"]);
                opXML.ModifyNode("num4708", Request.Form["huiduf8"]);
                opXML.ModifyNode("num4709", Request.Form["huiduf9"]);
                opXML.ModifyNode("num4710", Request.Form["huiduf10"]);
                opXML.ModifyNode("num4711", Request.Form["huiduf11"]);
                opXML.ModifyNode("num4712", Request.Form["huiduf12"]);
                opXML.ModifyNode("num4713", Request.Form["huiduf13"]);
                opXML.ModifyNode("num4714", Request.Form["huiduf14"]);
                opXML.ModifyNode("num4715", Request.Form["huiduf15"]);
                opXML.ModifyNode("num4716", Request.Form["huiduf16"]);
                opXML.ModifyNode("num4717", Request.Form["huiduf17"]);
                opXML.ModifyNode("num4718", Request.Form["huiduf18"]);
                opXML.ModifyNode("num4719", Request.Form["huiduf19"]);
                opXML.ModifyNode("num4720", Request.Form["huiduf20"]);
                opXML.ModifyNode("num4721", Request.Form["huiduf21"]);
                opXML.ModifyNode("num4722", Request.Form["huiduf22"]);
                opXML.ModifyNode("num4723", Request.Form["huiduf23"]);
                opXML.ModifyNode("num4724", Request.Form["huiduf24"]);
                opXML.ModifyNode("num4725", Request.Form["huiduf25"]);
                opXML.ModifyNode("num4726", Request.Form["huiduf26"]);
                opXML.ModifyNode("num4727", Request.Form["huiduf27"]);
                opXML.ModifyNode("num4728", Request.Form["huiduf28"]);
                opXML.ModifyNode("num4729", Request.Form["huiduf29"]);
                opXML.ModifyNode("num4730", Request.Form["huiduf30"]);
                opXML.ModifyNode("num4731", Request.Form["huiduf31"]);
                opXML.ModifyNode("num4732", Request.Form["huiduf32"]);
                opXML.ModifyNode("num4733", Request.Form["huiduf33"]);
                opXML.ModifyNode("num4734", Request.Form["huiduf34"]);
                opXML.ModifyNode("num4735", Request.Form["huiduf35"]);
                opXML.ModifyNode("num4736", Request.Form["huiduf36"]);
                opXML.ModifyNode("num4737", Request.Form["huiduf37"]);
                opXML.ModifyNode("num4738", Request.Form["huiduf38"]);
                opXML.ModifyNode("num4739", Request.Form["huiduf39"]);
                opXML.ModifyNode("num4740", Request.Form["huiduf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }
        //灰度2读
        public ActionResult SendDataHD2()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] huiduer = new string[20];
            string[] huiduerf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            huiduer[1] = opXML.QueryNodeText("num2401");
            huiduer[2] = opXML.QueryNodeText("num2402");
            huiduer[3] = opXML.QueryNodeText("num2403");
            huiduer[4] = opXML.QueryNodeText("num2404");
            huiduer[5] = opXML.QueryNodeText("num2405");
            huiduer[6] = opXML.QueryNodeText("num2406");
            huiduer[7] = opXML.QueryNodeText("num2407");
            huiduer[8] = opXML.QueryNodeText("num2408");
            huiduer[9] = opXML.QueryNodeText("num2409");
            huiduer[10] = opXML.QueryNodeText("num2410");
            huiduer[11] = opXML.QueryNodeText("num2411");
            huiduer[12] = opXML.QueryNodeText("num2412");

            huiduerf[1] = opXML.QueryNodeText("num4801");
            huiduerf[2] = opXML.QueryNodeText("num4802");
            huiduerf[3] = opXML.QueryNodeText("num4803");
            huiduerf[4] = opXML.QueryNodeText("num4804");
            huiduerf[5] = opXML.QueryNodeText("num4805");
            huiduerf[6] = opXML.QueryNodeText("num4806");
            huiduerf[7] = opXML.QueryNodeText("num4807");
            huiduerf[8] = opXML.QueryNodeText("num4808");
            huiduerf[9] = opXML.QueryNodeText("num4809");
            huiduerf[10] = opXML.QueryNodeText("num4810");
            huiduerf[11] = opXML.QueryNodeText("num4811");
            huiduerf[12] = opXML.QueryNodeText("num4812");
            huiduerf[13] = opXML.QueryNodeText("num4813");
            huiduerf[14] = opXML.QueryNodeText("num4814");
            huiduerf[15] = opXML.QueryNodeText("num4815");
            huiduerf[16] = opXML.QueryNodeText("num4816");
            huiduerf[17] = opXML.QueryNodeText("num4817");
            huiduerf[18] = opXML.QueryNodeText("num4818");
            huiduerf[19] = opXML.QueryNodeText("num4819");
            huiduerf[20] = opXML.QueryNodeText("num4820");
            huiduerf[21] = opXML.QueryNodeText("num4821");
            huiduerf[22] = opXML.QueryNodeText("num4822");
            huiduerf[23] = opXML.QueryNodeText("num4823");
            huiduerf[24] = opXML.QueryNodeText("num4824");
            huiduerf[25] = opXML.QueryNodeText("num4825");
            huiduerf[26] = opXML.QueryNodeText("num4826");
            huiduerf[27] = opXML.QueryNodeText("num4827");
            huiduerf[28] = opXML.QueryNodeText("num4828");
            huiduerf[29] = opXML.QueryNodeText("num4829");
            huiduerf[30] = opXML.QueryNodeText("num4830");
            huiduerf[31] = opXML.QueryNodeText("num4831");
            huiduerf[32] = opXML.QueryNodeText("num4832");
            huiduerf[33] = opXML.QueryNodeText("num4833");
            huiduerf[34] = opXML.QueryNodeText("num4834");
            huiduerf[35] = opXML.QueryNodeText("num4835");
            huiduerf[36] = opXML.QueryNodeText("num4836");
            huiduerf[37] = opXML.QueryNodeText("num4837");
            huiduerf[38] = opXML.QueryNodeText("num4838");
            huiduerf[39] = opXML.QueryNodeText("num4839");
            huiduerf[40] = opXML.QueryNodeText("num4840");

            json = "{\"huiduer1\":\"" + huiduer[1] + "\","
                          + "\"huiduer2\":\"" + huiduer[2] + "\","
                          + "\"huiduer3\":\"" + huiduer[3] + "\","
                          + "\"huiduer4\":\"" + huiduer[4] + "\","
                          + "\"huiduer5\":\"" + huiduer[5] + "\","
                          + "\"huiduer6\":\"" + huiduer[6] + "\","
                          + "\"huiduer7\":\"" + huiduer[7] + "\","
                          + "\"huiduer8\":\"" + huiduer[8] + "\","
                          + "\"huiduer9\":\"" + huiduer[9] + "\","
                          + "\"huiduer10\":\"" + huiduer[10] + "\","
                          + "\"huiduer11\":\"" + huiduer[11] + "\","
                          + "\"huiduer12\":\"" + huiduer[12] + "\","

                          + "\"huiduerf1\":\"" + huiduerf[1] + "\","
                          + "\"huiduerf2\":\"" + huiduerf[2] + "\","
                          + "\"huiduerf3\":\"" + huiduerf[3] + "\","
                          + "\"huiduerf4\":\"" + huiduerf[4] + "\","
                          + "\"huiduerf5\":\"" + huiduerf[5] + "\","
                          + "\"huiduerf6\":\"" + huiduerf[6] + "\","
                          + "\"huiduerf7\":\"" + huiduerf[7] + "\","
                          + "\"huiduerf8\":\"" + huiduerf[8] + "\","
                          + "\"huiduerf9\":\"" + huiduerf[9] + "\","
                          + "\"huiduerf10\":\"" + huiduerf[10] + "\","
                          + "\"huiduerf11\":\"" + huiduerf[11] + "\","
                          + "\"huiduerf12\":\"" + huiduerf[12] + "\","
                          + "\"huiduerf13\":\"" + huiduerf[13] + "\","
                          + "\"huiduerf14\":\"" + huiduerf[14] + "\","
                          + "\"huiduerf15\":\"" + huiduerf[15] + "\","
                          + "\"huiduerf16\":\"" + huiduerf[16] + "\","
                          + "\"huiduerf17\":\"" + huiduerf[17] + "\","
                          + "\"huiduerf18\":\"" + huiduerf[18] + "\","
                          + "\"huiduerf19\":\"" + huiduerf[19] + "\","
                          + "\"huiduerf20\":\"" + huiduerf[20] + "\","
                          + "\"huiduerf21\":\"" + huiduerf[21] + "\","
                          + "\"huiduerf22\":\"" + huiduerf[22] + "\","
                          + "\"huiduerf23\":\"" + huiduerf[23] + "\","
                          + "\"huiduerf24\":\"" + huiduerf[24] + "\","
                          + "\"huiduerf25\":\"" + huiduerf[25] + "\","
                          + "\"huiduerf26\":\"" + huiduerf[26] + "\","
                          + "\"huiduerf27\":\"" + huiduerf[27] + "\","
                          + "\"huiduerf28\":\"" + huiduerf[28] + "\","
                          + "\"huiduerf29\":\"" + huiduerf[29] + "\","
                          + "\"huiduerf30\":\"" + huiduerf[30] + "\","
                          + "\"huiduerf31\":\"" + huiduerf[31] + "\","
                          + "\"huiduerf32\":\"" + huiduerf[32] + "\","
                          + "\"huiduerf33\":\"" + huiduerf[33] + "\","
                          + "\"huiduerf34\":\"" + huiduerf[34] + "\","
                          + "\"huiduerf35\":\"" + huiduerf[35] + "\","
                          + "\"huiduerf36\":\"" + huiduerf[36] + "\","
                          + "\"huiduerf37\":\"" + huiduerf[37] + "\","
                          + "\"huiduerf38\":\"" + huiduerf[38] + "\","
                          + "\"huiduerf39\":\"" + huiduerf[39] + "\","
                          + "\"huiduerf40\":\"" + huiduerf[40] + "\"}";
            return Content(json);
        }
        //灰度2写
        public ActionResult postDataHD2()
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
                opXML.ModifyNode("num2401", Request.Form["huiduer1"]);
                opXML.ModifyNode("num2402", Request.Form["huiduer2"]);
                opXML.ModifyNode("num2403", Request.Form["huiduer3"]);
                opXML.ModifyNode("num2404", Request.Form["huiduer4"]);
                opXML.ModifyNode("num2405", Request.Form["huiduer5"]);
                opXML.ModifyNode("num2406", Request.Form["huiduer6"]);
                opXML.ModifyNode("num2407", Request.Form["huiduer7"]);
                opXML.ModifyNode("num2408", Request.Form["huiduer8"]);
                opXML.ModifyNode("num2409", Request.Form["huiduer9"]);
                opXML.ModifyNode("num2410", Request.Form["huiduer10"]);
                opXML.ModifyNode("num2411", Request.Form["huiduer11"]);
                opXML.ModifyNode("num2412", Request.Form["huiduer12"]);

                opXML.ModifyNode("num4801", Request.Form["huiduerf1"]);
                opXML.ModifyNode("num4802", Request.Form["huiduerf2"]);
                opXML.ModifyNode("num4803", Request.Form["huiduerf3"]);
                opXML.ModifyNode("num4804", Request.Form["huiduerf4"]);
                opXML.ModifyNode("num4805", Request.Form["huiduerf5"]);
                opXML.ModifyNode("num4806", Request.Form["huiduerf6"]);
                opXML.ModifyNode("num4807", Request.Form["huiduerf7"]);
                opXML.ModifyNode("num4808", Request.Form["huiduerf8"]);
                opXML.ModifyNode("num4809", Request.Form["huiduerf9"]);
                opXML.ModifyNode("num4810", Request.Form["huiduerf10"]);
                opXML.ModifyNode("num4811", Request.Form["huiduerf11"]);
                opXML.ModifyNode("num4812", Request.Form["huiduerf12"]);
                opXML.ModifyNode("num4813", Request.Form["huiduerf13"]);
                opXML.ModifyNode("num4814", Request.Form["huiduerf14"]);
                opXML.ModifyNode("num4815", Request.Form["huiduerf15"]);
                opXML.ModifyNode("num4816", Request.Form["huiduerf16"]);
                opXML.ModifyNode("num4817", Request.Form["huiduerf17"]);
                opXML.ModifyNode("num4818", Request.Form["huiduerf18"]);
                opXML.ModifyNode("num4819", Request.Form["huiduerf19"]);
                opXML.ModifyNode("num4820", Request.Form["huiduerf20"]);
                opXML.ModifyNode("num4821", Request.Form["huiduerf21"]);
                opXML.ModifyNode("num4822", Request.Form["huiduerf22"]);
                opXML.ModifyNode("num4823", Request.Form["huiduerf23"]);
                opXML.ModifyNode("num4824", Request.Form["huiduerf24"]);
                opXML.ModifyNode("num4825", Request.Form["huiduerf25"]);
                opXML.ModifyNode("num4826", Request.Form["huiduerf26"]);
                opXML.ModifyNode("num4827", Request.Form["huiduerf27"]);
                opXML.ModifyNode("num4828", Request.Form["huiduerf28"]);
                opXML.ModifyNode("num4829", Request.Form["huiduerf29"]);
                opXML.ModifyNode("num4830", Request.Form["huiduerf30"]);
                opXML.ModifyNode("num4831", Request.Form["huiduerf31"]);
                opXML.ModifyNode("num4832", Request.Form["huiduerf32"]);
                opXML.ModifyNode("num4833", Request.Form["huiduerf33"]);
                opXML.ModifyNode("num4834", Request.Form["huiduerf34"]);
                opXML.ModifyNode("num4835", Request.Form["huiduerf35"]);
                opXML.ModifyNode("num4836", Request.Form["huiduerf36"]);
                opXML.ModifyNode("num4837", Request.Form["huiduerf37"]);
                opXML.ModifyNode("num4838", Request.Form["huiduerf38"]);
                opXML.ModifyNode("num4839", Request.Form["huiduerf39"]);
                opXML.ModifyNode("num4840", Request.Form["huiduerf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //深度1读
        public ActionResult SendDataSD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] shendu = new string[20];
            string[] shenduf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            shendu[1] = opXML.QueryNodeText("num1701");
            shendu[2] = opXML.QueryNodeText("num1702");
            shendu[3] = opXML.QueryNodeText("num1703");
            shendu[4] = opXML.QueryNodeText("num1704");
            shendu[5] = opXML.QueryNodeText("num1705");
            shendu[6] = opXML.QueryNodeText("num1706");
            shendu[7] = opXML.QueryNodeText("num1707");
            shendu[8] = opXML.QueryNodeText("num1708");
            shendu[9] = opXML.QueryNodeText("num1709");
            shendu[10] = opXML.QueryNodeText("num1710");
            shendu[11] = opXML.QueryNodeText("num1711");
            shendu[12] = opXML.QueryNodeText("num1712");

            shenduf[1] = opXML.QueryNodeText("num4501");
            shenduf[2] = opXML.QueryNodeText("num4502");
            shenduf[3] = opXML.QueryNodeText("num4503");
            shenduf[4] = opXML.QueryNodeText("num4504");
            shenduf[5] = opXML.QueryNodeText("num4505");
            shenduf[6] = opXML.QueryNodeText("num4506");
            shenduf[7] = opXML.QueryNodeText("num4507");
            shenduf[8] = opXML.QueryNodeText("num4508");
            shenduf[9] = opXML.QueryNodeText("num4509");
            shenduf[10] = opXML.QueryNodeText("num4510");
            shenduf[11] = opXML.QueryNodeText("num4511");
            shenduf[12] = opXML.QueryNodeText("num4512");
            shenduf[13] = opXML.QueryNodeText("num4513");
            shenduf[14] = opXML.QueryNodeText("num4514");
            shenduf[15] = opXML.QueryNodeText("num4515");
            shenduf[16] = opXML.QueryNodeText("num4516");
            shenduf[17] = opXML.QueryNodeText("num4517");
            shenduf[18] = opXML.QueryNodeText("num4518");
            shenduf[19] = opXML.QueryNodeText("num4519");
            shenduf[20] = opXML.QueryNodeText("num4520");
            shenduf[21] = opXML.QueryNodeText("num4521");
            shenduf[22] = opXML.QueryNodeText("num4522");
            shenduf[23] = opXML.QueryNodeText("num4523");
            shenduf[24] = opXML.QueryNodeText("num4524");
            shenduf[25] = opXML.QueryNodeText("num4525");
            shenduf[26] = opXML.QueryNodeText("num4526");
            shenduf[27] = opXML.QueryNodeText("num4527");
            shenduf[28] = opXML.QueryNodeText("num4528");
            shenduf[29] = opXML.QueryNodeText("num4529");
            shenduf[30] = opXML.QueryNodeText("num4530");
            shenduf[31] = opXML.QueryNodeText("num4531");
            shenduf[32] = opXML.QueryNodeText("num4532");
            shenduf[33] = opXML.QueryNodeText("num4533");
            shenduf[34] = opXML.QueryNodeText("num4534");
            shenduf[35] = opXML.QueryNodeText("num4535");
            shenduf[36] = opXML.QueryNodeText("num4536");
            shenduf[37] = opXML.QueryNodeText("num4537");
            shenduf[38] = opXML.QueryNodeText("num4538");
            shenduf[39] = opXML.QueryNodeText("num4539");
            shenduf[40] = opXML.QueryNodeText("num4540");

            json = "{\"shendu1\":\"" + shendu[1] + "\","
                          + "\"shendu2\":\"" + shendu[2] + "\","
                          + "\"shendu3\":\"" + shendu[3] + "\","
                          + "\"shendu4\":\"" + shendu[4] + "\","
                          + "\"shendu5\":\"" + shendu[5] + "\","
                          + "\"shendu6\":\"" + shendu[6] + "\","
                          + "\"shendu7\":\"" + shendu[7] + "\","
                          + "\"shendu8\":\"" + shendu[8] + "\","
                          + "\"shendu9\":\"" + shendu[9] + "\","
                          + "\"shendu10\":\"" + shendu[10] + "\","
                          + "\"shendu11\":\"" + shendu[11] + "\","
                          + "\"shendu12\":\"" + shendu[12] + "\","

                          + "\"shenduf1\":\"" + shenduf[1] + "\","
                          + "\"shenduf2\":\"" + shenduf[2] + "\","
                          + "\"shenduf3\":\"" + shenduf[3] + "\","
                          + "\"shenduf4\":\"" + shenduf[4] + "\","
                          + "\"shenduf5\":\"" + shenduf[5] + "\","
                          + "\"shenduf6\":\"" + shenduf[6] + "\","
                          + "\"shenduf7\":\"" + shenduf[7] + "\","
                          + "\"shenduf8\":\"" + shenduf[8] + "\","
                          + "\"shenduf9\":\"" + shenduf[9] + "\","
                          + "\"shenduf10\":\"" + shenduf[10] + "\","
                          + "\"shenduf11\":\"" + shenduf[11] + "\","
                          + "\"shenduf12\":\"" + shenduf[12] + "\","
                          + "\"shenduf13\":\"" + shenduf[13] + "\","
                          + "\"shenduf14\":\"" + shenduf[14] + "\","
                          + "\"shenduf15\":\"" + shenduf[15] + "\","
                          + "\"shenduf16\":\"" + shenduf[16] + "\","
                          + "\"shenduf17\":\"" + shenduf[17] + "\","
                          + "\"shenduf18\":\"" + shenduf[18] + "\","
                          + "\"shenduf19\":\"" + shenduf[19] + "\","
                          + "\"shenduf20\":\"" + shenduf[20] + "\","
                          + "\"shenduf21\":\"" + shenduf[21] + "\","
                          + "\"shenduf22\":\"" + shenduf[22] + "\","
                          + "\"shenduf23\":\"" + shenduf[23] + "\","
                          + "\"shenduf24\":\"" + shenduf[24] + "\","
                          + "\"shenduf25\":\"" + shenduf[25] + "\","
                          + "\"shenduf26\":\"" + shenduf[26] + "\","
                          + "\"shenduf27\":\"" + shenduf[27] + "\","
                          + "\"shenduf28\":\"" + shenduf[28] + "\","
                          + "\"shenduf29\":\"" + shenduf[29] + "\","
                          + "\"shenduf30\":\"" + shenduf[30] + "\","
                          + "\"shenduf31\":\"" + shenduf[31] + "\","
                          + "\"shenduf32\":\"" + shenduf[32] + "\","
                          + "\"shenduf33\":\"" + shenduf[33] + "\","
                          + "\"shenduf34\":\"" + shenduf[34] + "\","
                          + "\"shenduf35\":\"" + shenduf[35] + "\","
                          + "\"shenduf36\":\"" + shenduf[36] + "\","
                          + "\"shenduf37\":\"" + shenduf[37] + "\","
                          + "\"shenduf38\":\"" + shenduf[38] + "\","
                          + "\"shenduf39\":\"" + shenduf[39] + "\","
                          + "\"shenduf40\":\"" + shenduf[40] + "\"}";
            return Content(json);
        }
        //深度1写
        public ActionResult postDataSD()
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
                opXML.ModifyNode("num1701", Request.Form["shendu1"]);
                opXML.ModifyNode("num1702", Request.Form["shendu2"]);
                opXML.ModifyNode("num1703", Request.Form["shendu3"]);
                opXML.ModifyNode("num1704", Request.Form["shendu4"]);
                opXML.ModifyNode("num1705", Request.Form["shendu5"]);
                opXML.ModifyNode("num1706", Request.Form["shendu6"]);
                opXML.ModifyNode("num1707", Request.Form["shendu7"]);
                opXML.ModifyNode("num1708", Request.Form["shendu8"]);
                opXML.ModifyNode("num1709", Request.Form["shendu9"]);
                opXML.ModifyNode("num1710", Request.Form["shendu10"]);
                opXML.ModifyNode("num1711", Request.Form["shendu11"]);
                opXML.ModifyNode("num1712", Request.Form["shendu12"]);

                opXML.ModifyNode("num4501", Request.Form["shenduf1"]);
                opXML.ModifyNode("num4502", Request.Form["shenduf2"]);
                opXML.ModifyNode("num4503", Request.Form["shenduf3"]);
                opXML.ModifyNode("num4504", Request.Form["shenduf4"]);
                opXML.ModifyNode("num4505", Request.Form["shenduf5"]);
                opXML.ModifyNode("num4506", Request.Form["shenduf6"]);
                opXML.ModifyNode("num4507", Request.Form["shenduf7"]);
                opXML.ModifyNode("num4508", Request.Form["shenduf8"]);
                opXML.ModifyNode("num4509", Request.Form["shenduf9"]);
                opXML.ModifyNode("num4510", Request.Form["shenduf10"]);
                opXML.ModifyNode("num4511", Request.Form["shenduf11"]);
                opXML.ModifyNode("num4512", Request.Form["shenduf12"]);
                opXML.ModifyNode("num4513", Request.Form["shenduf13"]);
                opXML.ModifyNode("num4514", Request.Form["shenduf14"]);
                opXML.ModifyNode("num4515", Request.Form["shenduf15"]);
                opXML.ModifyNode("num4516", Request.Form["shenduf16"]);
                opXML.ModifyNode("num4517", Request.Form["shenduf17"]);
                opXML.ModifyNode("num4518", Request.Form["shenduf18"]);
                opXML.ModifyNode("num4519", Request.Form["shenduf19"]);
                opXML.ModifyNode("num4520", Request.Form["shenduf20"]);
                opXML.ModifyNode("num4521", Request.Form["shenduf21"]);
                opXML.ModifyNode("num4522", Request.Form["shenduf22"]);
                opXML.ModifyNode("num4523", Request.Form["shenduf23"]);
                opXML.ModifyNode("num4524", Request.Form["shenduf24"]);
                opXML.ModifyNode("num4525", Request.Form["shenduf25"]);
                opXML.ModifyNode("num4526", Request.Form["shenduf26"]);
                opXML.ModifyNode("num4527", Request.Form["shenduf27"]);
                opXML.ModifyNode("num4528", Request.Form["shenduf28"]);
                opXML.ModifyNode("num4529", Request.Form["shenduf29"]);
                opXML.ModifyNode("num4530", Request.Form["shenduf30"]);
                opXML.ModifyNode("num4531", Request.Form["shenduf31"]);
                opXML.ModifyNode("num4532", Request.Form["shenduf32"]);
                opXML.ModifyNode("num4533", Request.Form["shenduf33"]);
                opXML.ModifyNode("num4534", Request.Form["shenduf34"]);
                opXML.ModifyNode("num4535", Request.Form["shenduf35"]);
                opXML.ModifyNode("num4536", Request.Form["shenduf36"]);
                opXML.ModifyNode("num4537", Request.Form["shenduf37"]);
                opXML.ModifyNode("num4538", Request.Form["shenduf38"]);
                opXML.ModifyNode("num4539", Request.Form["shenduf39"]);
                opXML.ModifyNode("num4540", Request.Form["shenduf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }
        //深度2读
        public ActionResult SendDataSD2()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] shenduer = new string[20];
            string[] shenduerf = new string[50];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            shenduer[1] = opXML.QueryNodeText("num2901");
            shenduer[2] = opXML.QueryNodeText("num2902");
            shenduer[3] = opXML.QueryNodeText("num2903");
            shenduer[4] = opXML.QueryNodeText("num2904");
            shenduer[5] = opXML.QueryNodeText("num2905");
            shenduer[6] = opXML.QueryNodeText("num2906");
            shenduer[7] = opXML.QueryNodeText("num2907");
            shenduer[8] = opXML.QueryNodeText("num2908");
            shenduer[9] = opXML.QueryNodeText("num2909");
            shenduer[10] = opXML.QueryNodeText("num2910");
            shenduer[11] = opXML.QueryNodeText("num2911");
            shenduer[12] = opXML.QueryNodeText("num2912");

            shenduerf[1] = opXML.QueryNodeText("num4601");
            shenduerf[2] = opXML.QueryNodeText("num4602");
            shenduerf[3] = opXML.QueryNodeText("num4603");
            shenduerf[4] = opXML.QueryNodeText("num4604");
            shenduerf[5] = opXML.QueryNodeText("num4605");
            shenduerf[6] = opXML.QueryNodeText("num4606");
            shenduerf[7] = opXML.QueryNodeText("num4607");
            shenduerf[8] = opXML.QueryNodeText("num4608");
            shenduerf[9] = opXML.QueryNodeText("num4609");
            shenduerf[10] = opXML.QueryNodeText("num4610");
            shenduerf[11] = opXML.QueryNodeText("num4611");
            shenduerf[12] = opXML.QueryNodeText("num4612");
            shenduerf[13] = opXML.QueryNodeText("num4613");
            shenduerf[14] = opXML.QueryNodeText("num4614");
            shenduerf[15] = opXML.QueryNodeText("num4615");
            shenduerf[16] = opXML.QueryNodeText("num4616");
            shenduerf[17] = opXML.QueryNodeText("num4617");
            shenduerf[18] = opXML.QueryNodeText("num4618");
            shenduerf[19] = opXML.QueryNodeText("num4619");
            shenduerf[20] = opXML.QueryNodeText("num4620");
            shenduerf[21] = opXML.QueryNodeText("num4621");
            shenduerf[22] = opXML.QueryNodeText("num4622");
            shenduerf[23] = opXML.QueryNodeText("num4623");
            shenduerf[24] = opXML.QueryNodeText("num4624");
            shenduerf[25] = opXML.QueryNodeText("num4625");
            shenduerf[26] = opXML.QueryNodeText("num4626");
            shenduerf[27] = opXML.QueryNodeText("num4627");
            shenduerf[28] = opXML.QueryNodeText("num4628");
            shenduerf[29] = opXML.QueryNodeText("num4629");
            shenduerf[30] = opXML.QueryNodeText("num4630");
            shenduerf[31] = opXML.QueryNodeText("num4631");
            shenduerf[32] = opXML.QueryNodeText("num4632");
            shenduerf[33] = opXML.QueryNodeText("num4633");
            shenduerf[34] = opXML.QueryNodeText("num4634");
            shenduerf[35] = opXML.QueryNodeText("num4635");
            shenduerf[36] = opXML.QueryNodeText("num4636");
            shenduerf[37] = opXML.QueryNodeText("num4637");
            shenduerf[38] = opXML.QueryNodeText("num4638");
            shenduerf[39] = opXML.QueryNodeText("num4639");
            shenduerf[40] = opXML.QueryNodeText("num4640");

            json = "{\"shenduer1\":\"" + shenduer[1] + "\","
                          + "\"shenduer2\":\"" + shenduer[2] + "\","
                          + "\"shenduer3\":\"" + shenduer[3] + "\","
                          + "\"shenduer4\":\"" + shenduer[4] + "\","
                          + "\"shenduer5\":\"" + shenduer[5] + "\","
                          + "\"shenduer6\":\"" + shenduer[6] + "\","
                          + "\"shenduer7\":\"" + shenduer[7] + "\","
                          + "\"shenduer8\":\"" + shenduer[8] + "\","
                          + "\"shenduer9\":\"" + shenduer[9] + "\","
                          + "\"shenduer10\":\"" + shenduer[10] + "\","
                          + "\"shenduer11\":\"" + shenduer[11] + "\","
                          + "\"shenduer12\":\"" + shenduer[12] + "\","

                          + "\"shenduerf1\":\"" + shenduerf[1] + "\","
                          + "\"shenduerf2\":\"" + shenduerf[2] + "\","
                          + "\"shenduerf3\":\"" + shenduerf[3] + "\","
                          + "\"shenduerf4\":\"" + shenduerf[4] + "\","
                          + "\"shenduerf5\":\"" + shenduerf[5] + "\","
                          + "\"shenduerf6\":\"" + shenduerf[6] + "\","
                          + "\"shenduerf7\":\"" + shenduerf[7] + "\","
                          + "\"shenduerf8\":\"" + shenduerf[8] + "\","
                          + "\"shenduerf9\":\"" + shenduerf[9] + "\","
                          + "\"shenduerf10\":\"" + shenduerf[10] + "\","
                          + "\"shenduerf11\":\"" + shenduerf[11] + "\","
                          + "\"shenduerf12\":\"" + shenduerf[12] + "\","
                          + "\"shenduerf13\":\"" + shenduerf[13] + "\","
                          + "\"shenduerf14\":\"" + shenduerf[14] + "\","
                          + "\"shenduerf15\":\"" + shenduerf[15] + "\","
                          + "\"shenduerf16\":\"" + shenduerf[16] + "\","
                          + "\"shenduerf17\":\"" + shenduerf[17] + "\","
                          + "\"shenduerf18\":\"" + shenduerf[18] + "\","
                          + "\"shenduerf19\":\"" + shenduerf[19] + "\","
                          + "\"shenduerf20\":\"" + shenduerf[20] + "\","
                          + "\"shenduerf21\":\"" + shenduerf[21] + "\","
                          + "\"shenduerf22\":\"" + shenduerf[22] + "\","
                          + "\"shenduerf23\":\"" + shenduerf[23] + "\","
                          + "\"shenduerf24\":\"" + shenduerf[24] + "\","
                          + "\"shenduerf25\":\"" + shenduerf[25] + "\","
                          + "\"shenduerf26\":\"" + shenduerf[26] + "\","
                          + "\"shenduerf27\":\"" + shenduerf[27] + "\","
                          + "\"shenduerf28\":\"" + shenduerf[28] + "\","
                          + "\"shenduerf29\":\"" + shenduerf[29] + "\","
                          + "\"shenduerf30\":\"" + shenduerf[30] + "\","
                          + "\"shenduerf31\":\"" + shenduerf[31] + "\","
                          + "\"shenduerf32\":\"" + shenduerf[32] + "\","
                          + "\"shenduerf33\":\"" + shenduerf[33] + "\","
                          + "\"shenduerf34\":\"" + shenduerf[34] + "\","
                          + "\"shenduerf35\":\"" + shenduerf[35] + "\","
                          + "\"shenduerf36\":\"" + shenduerf[36] + "\","
                          + "\"shenduerf37\":\"" + shenduerf[37] + "\","
                          + "\"shenduerf38\":\"" + shenduerf[38] + "\","
                          + "\"shenduerf39\":\"" + shenduerf[39] + "\","
                          + "\"shenduerf40\":\"" + shenduerf[40] + "\"}";
            return Content(json);
        }
        //深度2写
        public ActionResult postDataSD2()
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
                opXML.ModifyNode("num2901", Request.Form["shenduer1"]);
                opXML.ModifyNode("num2902", Request.Form["shenduer2"]);
                opXML.ModifyNode("num2903", Request.Form["shenduer3"]);
                opXML.ModifyNode("num2904", Request.Form["shenduer4"]);
                opXML.ModifyNode("num2905", Request.Form["shenduer5"]);
                opXML.ModifyNode("num2906", Request.Form["shenduer6"]);
                opXML.ModifyNode("num2907", Request.Form["shenduer7"]);
                opXML.ModifyNode("num2908", Request.Form["shenduer8"]);
                opXML.ModifyNode("num2909", Request.Form["shenduer9"]);
                opXML.ModifyNode("num2910", Request.Form["shenduer10"]);
                opXML.ModifyNode("num2911", Request.Form["shenduer11"]);
                opXML.ModifyNode("num2912", Request.Form["shenduer12"]);

                opXML.ModifyNode("num4601", Request.Form["shenduerf1"]);
                opXML.ModifyNode("num4602", Request.Form["shenduerf2"]);
                opXML.ModifyNode("num4603", Request.Form["shenduerf3"]);
                opXML.ModifyNode("num4604", Request.Form["shenduerf4"]);
                opXML.ModifyNode("num4605", Request.Form["shenduerf5"]);
                opXML.ModifyNode("num4606", Request.Form["shenduerf6"]);
                opXML.ModifyNode("num4607", Request.Form["shenduerf7"]);
                opXML.ModifyNode("num4608", Request.Form["shenduerf8"]);
                opXML.ModifyNode("num4609", Request.Form["shenduerf9"]);
                opXML.ModifyNode("num4610", Request.Form["shenduerf10"]);
                opXML.ModifyNode("num4611", Request.Form["shenduerf11"]);
                opXML.ModifyNode("num4612", Request.Form["shenduerf12"]);
                opXML.ModifyNode("num4613", Request.Form["shenduerf13"]);
                opXML.ModifyNode("num4614", Request.Form["shenduerf14"]);
                opXML.ModifyNode("num4615", Request.Form["shenduerf15"]);
                opXML.ModifyNode("num4616", Request.Form["shenduerf16"]);
                opXML.ModifyNode("num4617", Request.Form["shenduerf17"]);
                opXML.ModifyNode("num4618", Request.Form["shenduerf18"]);
                opXML.ModifyNode("num4619", Request.Form["shenduerf19"]);
                opXML.ModifyNode("num4620", Request.Form["shenduerf20"]);
                opXML.ModifyNode("num4621", Request.Form["shenduerf21"]);
                opXML.ModifyNode("num4622", Request.Form["shenduerf22"]);
                opXML.ModifyNode("num4623", Request.Form["shenduerf23"]);
                opXML.ModifyNode("num4624", Request.Form["shenduerf24"]);
                opXML.ModifyNode("num4625", Request.Form["shenduerf25"]);
                opXML.ModifyNode("num4626", Request.Form["shenduerf26"]);
                opXML.ModifyNode("num4627", Request.Form["shenduerf27"]);
                opXML.ModifyNode("num4628", Request.Form["shenduerf28"]);
                opXML.ModifyNode("num4629", Request.Form["shenduerf29"]);
                opXML.ModifyNode("num4630", Request.Form["shenduerf30"]);
                opXML.ModifyNode("num4631", Request.Form["shenduerf31"]);
                opXML.ModifyNode("num4632", Request.Form["shenduerf32"]);
                opXML.ModifyNode("num4633", Request.Form["shenduerf33"]);
                opXML.ModifyNode("num4634", Request.Form["shenduerf34"]);
                opXML.ModifyNode("num4635", Request.Form["shenduerf35"]);
                opXML.ModifyNode("num4636", Request.Form["shenduerf36"]);
                opXML.ModifyNode("num4637", Request.Form["shenduerf37"]);
                opXML.ModifyNode("num4638", Request.Form["shenduerf38"]);
                opXML.ModifyNode("num4639", Request.Form["shenduerf39"]);
                opXML.ModifyNode("num4640", Request.Form["shenduerf40"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //背景阈值读
        public ActionResult SendDataBJYZ()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] bei = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            bei[1] = opXML.QueryNodeText("num0101");
            bei[2] = opXML.QueryNodeText("num0102");
            bei[3] = opXML.QueryNodeText("num0103");
            bei[4] = opXML.QueryNodeText("num0104");
            bei[5] = opXML.QueryNodeText("num0105");
            bei[6] = opXML.QueryNodeText("num0106");
            bei[7] = opXML.QueryNodeText("num0107");
            bei[8] = opXML.QueryNodeText("num0108");
            bei[9] = opXML.QueryNodeText("num0109");
            bei[10] = opXML.QueryNodeText("num0110");
            bei[11] = opXML.QueryNodeText("num0111");
            bei[12] = opXML.QueryNodeText("num0112");
            bei[13] = opXML.QueryNodeText("num0113");
            bei[14] = opXML.QueryNodeText("num0114");
            bei[15] = opXML.QueryNodeText("num0115");
            bei[16] = opXML.QueryNodeText("num0116");
            bei[17] = opXML.QueryNodeText("num0117");
            bei[18] = opXML.QueryNodeText("num0118");
            bei[19] = opXML.QueryNodeText("num0119");
            bei[20] = opXML.QueryNodeText("num0120");

            json = "{\"bei1\":\"" + bei[1] + "\","
                          + "\"bei2\":\"" + bei[2] + "\","
                          + "\"bei3\":\"" + bei[3] + "\","
                          + "\"bei4\":\"" + bei[4] + "\","
                          + "\"bei5\":\"" + bei[5] + "\","
                          + "\"bei6\":\"" + bei[6] + "\","
                          + "\"bei7\":\"" + bei[7] + "\","
                          + "\"bei8\":\"" + bei[8] + "\","
                          + "\"bei9\":\"" + bei[9] + "\","
                          + "\"bei10\":\"" + bei[10] + "\","
                          + "\"bei11\":\"" + bei[11] + "\","
                          + "\"bei12\":\"" + bei[12] + "\","
                          + "\"bei13\":\"" + bei[13] + "\","
                          + "\"bei14\":\"" + bei[14] + "\","
                          + "\"bei15\":\"" + bei[15] + "\","
                          + "\"bei16\":\"" + bei[16] + "\","
                          + "\"bei17\":\"" + bei[17] + "\","
                          + "\"bei18\":\"" + bei[18] + "\","
                          + "\"bei19\":\"" + bei[19] + "\","
                          + "\"bei20\":\"" + bei[20] + "\"}";
            return Content(json);
        }
        //背景阈值写
        public ActionResult postDataBJYZ()
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
                opXML.ModifyNode("num0101", Request.Form["bei1"]);
                opXML.ModifyNode("num0102", Request.Form["bei2"]);
                opXML.ModifyNode("num0103", Request.Form["bei3"]);
                opXML.ModifyNode("num0104", Request.Form["bei4"]);
                opXML.ModifyNode("num0105", Request.Form["bei5"]);
                opXML.ModifyNode("num0106", Request.Form["bei6"]);
                opXML.ModifyNode("num0107", Request.Form["bei7"]);
                opXML.ModifyNode("num0108", Request.Form["bei8"]);
                opXML.ModifyNode("num0109", Request.Form["bei9"]);
                opXML.ModifyNode("num0110", Request.Form["bei10"]);
                opXML.ModifyNode("num0111", Request.Form["bei11"]);
                opXML.ModifyNode("num0112", Request.Form["bei12"]);
                opXML.ModifyNode("num0113", Request.Form["bei13"]);
                opXML.ModifyNode("num0114", Request.Form["bei14"]);
                opXML.ModifyNode("num0115", Request.Form["bei15"]);
                opXML.ModifyNode("num0116", Request.Form["bei16"]);
                opXML.ModifyNode("num0117", Request.Form["bei17"]);
                opXML.ModifyNode("num0118", Request.Form["bei18"]);
                opXML.ModifyNode("num0119", Request.Form["bei19"]);
                opXML.ModifyNode("num0120", Request.Form["bei20"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //颜色行面积读
        public ActionResult SendDataYSHMJ()
        {
          //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] hang = new string[30];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            hang[1] = opXML.QueryNodeText("num3201");
            hang[2] = opXML.QueryNodeText("num3202");
            hang[3] = opXML.QueryNodeText("num3203");
            hang[4] = opXML.QueryNodeText("num3204");
            hang[5] = opXML.QueryNodeText("num3205");
            hang[6] = opXML.QueryNodeText("num3206");
            hang[7] = opXML.QueryNodeText("num3207");
            hang[8] = opXML.QueryNodeText("num3208");
            hang[9] = opXML.QueryNodeText("num3209");
            hang[10] = opXML.QueryNodeText("num3210");
            hang[11] = opXML.QueryNodeText("num3211");
            hang[12] = opXML.QueryNodeText("num3212");
            hang[13] = opXML.QueryNodeText("num3213");
            hang[14] = opXML.QueryNodeText("num3214");
            hang[15] = opXML.QueryNodeText("num3215");
            hang[16] = opXML.QueryNodeText("num3216");
            hang[17] = opXML.QueryNodeText("num3217");
            hang[18] = opXML.QueryNodeText("num3218");
            hang[19] = opXML.QueryNodeText("num3219");
            hang[20] = opXML.QueryNodeText("num3220");

            json = "{\"hang1\":\"" + hang[1] + "\","
                          + "\"hang2\":\"" + hang[2] + "\","
                          + "\"hang3\":\"" + hang[3] + "\","
                          + "\"hang4\":\"" + hang[4] + "\","
                          + "\"hang5\":\"" + hang[5] + "\","
                          + "\"hang6\":\"" + hang[6] + "\","
                          + "\"hang7\":\"" + hang[7] + "\","
                          + "\"hang8\":\"" + hang[8] + "\","
                          + "\"hang9\":\"" + hang[9] + "\","
                          + "\"hang10\":\"" + hang[10] + "\","
                          + "\"hang11\":\"" + hang[11] + "\","
                          + "\"hang12\":\"" + hang[12] + "\","
                          + "\"hang13\":\"" + hang[13] + "\","
                          + "\"hang14\":\"" + hang[14] + "\","
                          + "\"hang15\":\"" + hang[15] + "\","
                          + "\"hang16\":\"" + hang[16] + "\","
                          + "\"hang17\":\"" + hang[17] + "\","
                          + "\"hang18\":\"" + hang[18] + "\","
                          + "\"hang19\":\"" + hang[19] + "\","
                          + "\"hang20\":\"" + hang[20] + "\"}";
            return Content(json);


        }

        //颜色行面积写
        public ActionResult postDataYSHMJ()
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
                opXML.ModifyNode("num3201", Request.Form["hang1"]);
                opXML.ModifyNode("num3202", Request.Form["hang2"]);
                opXML.ModifyNode("num3203", Request.Form["hang3"]);
                opXML.ModifyNode("num3204", Request.Form["hang4"]);
                opXML.ModifyNode("num3205", Request.Form["hang5"]);
                opXML.ModifyNode("num3206", Request.Form["hang6"]);
                opXML.ModifyNode("num3207", Request.Form["hang7"]);
                opXML.ModifyNode("num3208", Request.Form["hang8"]);
                opXML.ModifyNode("num3209", Request.Form["hang9"]);
                opXML.ModifyNode("num3210", Request.Form["hang10"]);
                opXML.ModifyNode("num3211", Request.Form["hang11"]);
                opXML.ModifyNode("num3212", Request.Form["hang12"]);
                opXML.ModifyNode("num3213", Request.Form["hang13"]);
                opXML.ModifyNode("num3214", Request.Form["hang14"]);
                opXML.ModifyNode("num3215", Request.Form["hang15"]);
                opXML.ModifyNode("num3216", Request.Form["hang16"]);
                opXML.ModifyNode("num3217", Request.Form["hang17"]);
                opXML.ModifyNode("num3218", Request.Form["hang18"]);
                opXML.ModifyNode("num3219", Request.Form["hang19"]);
                opXML.ModifyNode("num3220", Request.Form["hang20"]);
                opXML.saveFile();
                return Content("Success");
            }
            catch
            {
                return Content("Error");
            }
        }

        //颜色敏感强度读
        public ActionResult SendDataYSMGQD()
        {
            //声明设备ID，文件名，查询语句，路径，路径，JSON
            string deviceID, fileName, hs_sql, path, newPath, json;
            string[] hang = new string[10];
            deviceID = Request.Form["deviceID"];
            fileName = Request.Form["fileName"];
            //获得文件路径
            hs_sql = "select pathName from DeviceInfo where DeviceID='" + deviceID + "'";
            path = DbHelperSQL.ExecuteQuery(hs_sql);
            newPath = System.IO.Path.Combine(path, fileName);
            newPath = newPath + ".xml";
            //读取值
            XMLHelper opXML = new XMLHelper(newPath);
            hang[1] = opXML.QueryNodeText("num3301");
            hang[2] = opXML.QueryNodeText("num3302");
            hang[3] = opXML.QueryNodeText("num3303");
            hang[4] = opXML.QueryNodeText("num3304");
            hang[5] = opXML.QueryNodeText("num3305");
            hang[6] = opXML.QueryNodeText("num3306");

            json = "{\"hang1\":\"" + hang[1] + "\","
                          + "\"hang2\":\"" + hang[2] + "\","
                          + "\"hang3\":\"" + hang[3] + "\","
                          + "\"hang4\":\"" + hang[4] + "\","
                          + "\"hang5\":\"" + hang[5] + "\","
                          + "\"hang6\":\"" + hang[6] + "\"}";
            return Content(json);
        }

        //颜色敏感强度写
        public ActionResult postDataYSMGQD()
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
                opXML.ModifyNode("num3301", Request.Form["hang1"]);
                opXML.ModifyNode("num3302", Request.Form["hang2"]);
                opXML.ModifyNode("num3303", Request.Form["hang3"]);
                opXML.ModifyNode("num3304", Request.Form["hang4"]);
                opXML.ModifyNode("num3305", Request.Form["hang5"]);
                opXML.ModifyNode("num3306", Request.Form["hang6"]);
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