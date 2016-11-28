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
    private static string SQLString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    private SqlCommand command = null;
    private SqlDataReader read = null;
    private SqlConnection conn = new SqlConnection(SQLString);
    private Boolean flag = true;

    public User login(String name, String password)
    {
        User user = null;
        try
        {
            conn.Open();
            String sql = "select id, name, usertype,image from person where name = @name and password = @password";
            command = new SqlCommand(sql, conn);
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
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            return null;
        }
        finally
        {
            read.Close();
            if (conn != null)
                conn.Close();
            if (command != null)
                command.Dispose();
            conn.Dispose();
        }
    }

    public Boolean callbackvoid(String sql, SqlParameter[] args)
    {
        try
        {
            conn.Open();
            command = new SqlCommand(sql, conn);
            foreach (SqlParameter sqlp in args)
            {
                command.Parameters.Add(sqlp);
            }
            command.ExecuteNonQuery();
        }
        catch (SqlException e)
        {
            flag = false;
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (conn != null)
                conn.Close();
            if (command != null)
                command.Dispose();
            conn.Dispose();
        }

        return flag;
    }

    public User getUserByName(String name)
    {
        User user = null;
        try
        {
            conn.Open();
            String sql = "select id, name, usertype,image from person where name = @name";
            command = new SqlCommand(sql, conn);
            SqlParameter theName = new SqlParameter("@name", name);
            command.Parameters.Add(theName);
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
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            return null;
        }
        finally
        {
            read.Close();
            if (conn != null)
                conn.Close();
            if (command != null)
                command.Dispose();
            conn.Dispose();
        }
    }
}