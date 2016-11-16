using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace theProject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["myCookie"];
            if (cookies != null)
            {
                String name  = cookies["name"];
                String pwd = cookies["password"];
                cookies.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookies);
                doLogin(name, pwd);
            }
        }

        protected void btn_enter(object sender, EventArgs e)
        {
            String name = Request["actNum"];
            String pwd = Request["password"];
            if (name.Equals("") || password.Equals(""))
            {
                messageBox("请输入完整的信息");
            }
            else
            {
                doLogin(name, pwd);
            }
        }

        public void messageBox(String msg)
        {
            Response.Write(@"<script language = 'javascript'>alert('" + msg + "')</script>");
        }

        public String md5(String pwd)
        {
            String md5Pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd,"MD5");
            return md5Pwd;
        }

        public void doLogin(String name, String pwd)
        {
            HttpCookie cookie = null;
            DBOpreation DB = new DBOpreation();
            pwd = md5(pwd);
            User user = DB.login(name, pwd);
            if (user != null)
            {
                Session.Add("user", user);
                cookie = new HttpCookie("myCookie");
                cookie.Values.Add("name", name);
                cookie.Values.Add("password", pwd);
                cookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cookie);
                Response.Redirect("/index.aspx");
            }
            else
            {
                messageBox("登录失败");
            }
        }


    }
}