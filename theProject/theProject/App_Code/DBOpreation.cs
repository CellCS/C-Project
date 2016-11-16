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
                String sql = "select * from person where name = @name and password = @password";
                command = new SqlCommand(sql, sqlcon);
                SqlParameter theName = new SqlParameter("@name", name);
                SqlParameter thePwd = new SqlParameter("@password", password);
                command.Parameters.Add(theName);
                command.Parameters.Add(thePwd);
                read = command.ExecuteReader();
                while (read.NextResult())
                {
                    user.setId(read.GetInt32(0));
                    user.setName(read.GetString(1));
                    user.setType(read.GetInt32(3));
                    user.setImage(read.GetString(7));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return user;
    }
}