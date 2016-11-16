using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace theProject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                HttpCookie cookie = null;
                DBOpreation DB = new DBOpreation();
                User user = DB.login(name, pwd);
                if (user != null)
                {
                    Session.Add("user", user);
                    cookie = new HttpCookie("myCookie");
                    cookie.Values.Add("name", name);
                    cookie.Values.Add("password", pwd);
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                    Response.Redirect("/...");
                }
                else
                {
                    messageBox("登录失败");
                }
            }
        }

        public void messageBox(String msg)
        {
            Response.Write(@"<script language = 'javascript'>alert('" + msg + "')</script>");
        }
    }
}