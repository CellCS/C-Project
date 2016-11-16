using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Product 的摘要说明
/// </summary>
public class Product
{
    private int id;
    private String name;
    private int price;
    private String detail;
    private String tag;
    private String image;

    public void setId(int id)
    {
        this.id = id;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public void setPrice(int price)
    {
      this.price = price;
    }

    public void setDetail( String detail)
    {
        this.detail = detail;
    }

    public void setTag(String tag)
    {
        this.tag = tag;
    }

    public void  setImage(String image)
    {
        this.image = image;
    }

    public int getId()
    {
        return this.id;
    }

    public String getName()
    {
        return this.name;
    }

    public int getPrice()
    {
        return this.price;
    }

    public String getDetail()
    {
        return this.detail;
    }

    public String getTag()
    {
        return  this.tag;
    }

    public String getImage()
    {
        return this.image;
    }
}