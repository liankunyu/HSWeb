using DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{

    public class ConnectServerController : Controller
    {
        //Socket socketSend;
        // GET: ConnectServer
        public ActionResult connServer()
        {
            return View();
        }
        public ActionResult deviceManage()
        {
            return View();
        }
        public ActionResult UserManage()
        {
            return View();
        }
        public ActionResult VerifyDevice()
        {
            string deviceID = Request.Form["deviceID"];

            DataTable dt1 = new DataTable();
            string hs_sql = "select * from DevicePing where DeviceID='" + deviceID + "'";
            dt1 = DbHelperSQL.OpenTable(hs_sql);
            if (dt1.Rows.Count > 0)
            {
                return Content("Success");
            }
            else
            {
                return Content("Nofound");
            }
        }

        //设备信息读
        public ActionResult DeviceInfo()
        {
            string json = "";
            DataTable dt = new DataTable();
            string hs_sql = "select * from DeviceInfo";
            dt = DbHelperSQL.OpenTable(hs_sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string json1 = "{\"DeviceID\":\"" + dt.Rows[i][0].ToString().Trim() + "\","

                                  + "\"ip\":\"" + dt.Rows[i][2].ToString().Trim() + "\","
                                  + "\"connectDT\":\"" + dt.Rows[i][3].ToString().Trim() + "\","
                                  + "\"activeDT\":\"" + dt.Rows[i][4].ToString().Trim() + "\"},";
                    json += json1;
                }
                json = json.Substring(0, json.Length - 1);
                json = "{\"total\":" + dt.Rows.Count + ",\"rows\":[" + json + "]}";
                return Content(json);
            }
            else
            {
                return Content("NoFound");
            }
        }
        //删除设备信息
        public ActionResult Device_Delete()
        {
            string DeviceID = Request.Form["DeviceID"];


            string hs_sql = "DELETE FROM DeviceInfo where DeviceID='" + DeviceID + "'";
            int row = DbHelperSQL.Execute(hs_sql);
            if (row > 0)
            {
                return Content("OK");
            }
            else
            {
                return Content("Nofound");
            }
        }
        //添加设备信息
        public ActionResult Device_Add()
        {
            string xj_DeviceID = Request.Form["xj_DeviceID"];
            DataTable dt1 = new DataTable();
            string hs_sql = "select * from DeviceInfo where DeviceID='" + xj_DeviceID + "'";
            dt1 = DbHelperSQL.OpenTable(hs_sql);
            if (dt1.Rows.Count == 0)
            {
                string newPath = System.IO.Path.Combine(@"D:\HS", xj_DeviceID);
                hs_sql = "INSERT INTO DeviceInfo (DeviceID,pathName) VALUES ('" + xj_DeviceID + "','" + newPath + "')";
                int row = DbHelperSQL.Execute(hs_sql);
                if (row > 0)
                {
                    return Content("OK");
                }
                else
                {
                    return Content("Error");
                }
            }
            else
            {
                return Content("Error");
            }
        }

        //用户信息读
        public ActionResult UserInfo()
        {
            string json = "";
            DataTable dt = new DataTable();
            string hs_sql = "select * from UserInfo";
            dt = DbHelperSQL.OpenTable(hs_sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string json1 = "{\"userName\":\"" + dt.Rows[i][0].ToString().Trim() + "\","

                                  + "\"passWord\":\"" + dt.Rows[i][1].ToString().Trim() + "\","
                                   + "\"regTime\":\"" + dt.Rows[i][3].ToString().Trim() + "\","
                                  + "\"Jurisdiction\":\"" + dt.Rows[i][4].ToString().Trim() + "\"},";
                    json += json1;
                }
                json = json.Substring(0, json.Length - 1);
                json = "{\"total\":" + dt.Rows.Count + ",\"rows\":[" + json + "]}";
                return Content(json);
            }
            else
            {
                return Content("NoFound");
            }
        }
        //添加用户信息
        public ActionResult User_Add()
        {
            string xj_userName = Request.Form["xj_userName"];
            string xj_pwd = Request.Form["xj_pwd"];

            DataTable dt = new DataTable();
            string hs_sql = "select * from UserInfo where userName='" + xj_userName + "'";
            dt = DbHelperSQL.OpenTable(hs_sql);
            if (dt.Rows.Count == 0)
            {
                hs_sql = "INSERT INTO UserInfo (userName,passWord,regTime,Jurisdiction) VALUES ('" + xj_userName + "','" + xj_pwd + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','0')";
                int row = DbHelperSQL.Execute(hs_sql);
                if (row > 0)
                {
                    return Content("OK");
                }
                else
                {
                    return Content("Error");
                }
            }
            else
            {
                return Content("Error");
            }
        }
        //删除设备信息
        public ActionResult User_Delete()
        {
            string userName = Request.Form["userName"];


            string hs_sql = "DELETE FROM UserInfo where userName='" + userName + "'";
            int row = DbHelperSQL.Execute(hs_sql);
            if (row > 0)
            {
                return Content("OK");
            }
            else
            {
                return Content("Nofound");
            }
        }

        //修改用户信息
        public ActionResult User_Modify()
        {
            string xg_userName = Request.Form["xg_userName"];
            string xg_passWord = Request.Form["xg_passWord"];
            string hs_sql = "UPDATE UserInfo SET passWord = '"+xg_passWord+"' WHERE userName = '"+xg_userName+"'";
            int row = DbHelperSQL.Execute(hs_sql);
            if (row > 0)
            {
                return Content("OK");
            }
            else
            {
                return Content("Error");
            }
        }
    }
}