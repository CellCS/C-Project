using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace theProject
{
    public partial class enroll : System.Web.UI.Page
    {
        DBOpreation opreation = new DBOpreation();
        String path = "";
        String name = "";

        protected void Page_Load(object sender, EventArgs e)
        { 
        }

        protected void submit1_Click(object sender, EventArgs e)
        {
            name = userName.Text.Trim();
            String password = passWord.Text.Trim();
            String check = checkPassWord.Text.Trim();
            String tele = telNum.Text.Trim();
            String qq = QQNum.Text.Trim();
            String info = informText.Text.Trim();

            String sql = "insert into person(name, password, usertype, detail, QQNum, tele,image) values(@name,@password,1,@detail,@QQnum,@tel,@image)";
            try
            {
                opreation.callbackvoid(sql, new SqlParameter[] {
                    new SqlParameter("@name",name),
                    new SqlParameter("@password",md5(password)),
                    new SqlParameter("@detail", info),
                    new SqlParameter("@QQnum",qq),
                    new SqlParameter("@tel",tele),
                    new SqlParameter("@image",Session["path"].ToString())
              });
                Session.Remove("path");
                Response.Redirect("/login.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                messageBox("创建失败");
            }
        }
        public void messageBox(String msg)
        {
            Response.Write(@"<script language = 'javascript'>alert('" + msg + "')</script>");
        }

        public String md5(String pwd)
        {
            String md5Pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            return md5Pwd;
        }

        protected void userName_TextChanged(object sender, EventArgs e)
        {
            User user = opreation.getUserByName(userName.Text.Trim());
            if(user != null)
            {
                messageBox("该用户名已被注册");
                userName.Text = "";
            }
        }

        protected void upload1_Click(object sender, EventArgs e)
        {
            if (userName.Text.Trim().Equals(""))
            {
                messageBox("请先完善个人信息");
            }
            else
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFile file = Request.Files[i];
                    if (file.ContentLength > 0)
                    {
                        if (file.ContentType.Contains("image/"))
                        {
                            using (System.Drawing.Image img = System.Drawing.Image.FromStream(file.InputStream))
                            {
                                string FileName = System.IO.Path.GetFileName(file.FileName);
                                string[] SplitFileName = FileName.Split('.');
                                 String im = userName.Text.Trim() + "." + SplitFileName[1];
                                img.Save(Server.MapPath("~//userImages//" + im));
                                this.userPhoto.ImageUrl = "userImages/" + im;
                                path = "userImages/" + im;
                                Session["picName"] = im;
                                Session["path"] = path;
                            }
                        }
                    }
                }
       
            }
        }
    }
}