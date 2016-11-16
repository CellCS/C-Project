using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using theProject;

/// <summary>
/// 数据库的基本操作
/// </summary>
public class DBOpreation
{
    private string SQLString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    private SqlCommand command = null;
    private SqlDataReader read = null;
    String id;

    public User login(String name, String password)
    {
        User user = null;
        try
        {
            using (SqlConnection sqlcon = new SqlConnection(SQLString))
            {
                sqlcon.Open();
                String sql = "select id, name, usertype,image from person where name = @name and password = @password";
                command = new SqlCommand(sql, sqlcon);
                SqlParameter theName = new SqlParameter("@name", name);
                SqlParameter thePwd = new SqlParameter("@password", password);
                command.Parameters.Add(theName);
                command.Parameters.Add(thePwd);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    user = new User();
                    user.setId((int)read["id"]);
                    user.setName(read["name"].ToString());
                    user.setStyle((int)read["usertype"]);
                    user.setImage(read["image"].ToString());
                }
                return user;
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            return null;
        }
    }
}