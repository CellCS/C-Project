using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// User 的摘要说明
/// </summary>
public class User
{
    private int id;
    private String name;
    private String password;
    private int style;
    private String detail;
    private String tele;
    private String QQnum;
    private String image;

    public void setId(int id)
    {
        this.id = id;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public void setPassword(String password)
    {
        this.password = password;
    }

    public void setStyle(int style)
    {
        this.style = style;
    }

    public void setDetail(String detail)
    {
        this.detail = detail;
    }

    public void setTele(String tele)
    {
        this.tele = tele;
    }

    public void setQQnum(String qq)
    {
        this.QQnum = qq;
    }

    public void setImage(String path)
    {
        this.image = path;
    }

    public int getId()
    {
        return this.id;
    }

    public String getName()
    {
        return this.name;
    }

    public String getPassword()
    {
        return this.password;
    }

    public int getStyle()
    {
        return this.style;
    }

    public String getDetail()
    {
        return this.detail;
    }

    public String getTele()
    {
        return this.tele;
    }

    public String getQQnum()
    {
        return this.QQnum;
    }

    public String getImage()
    {
        return this.image;
    }
}