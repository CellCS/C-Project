﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enroll.aspx.cs" Inherits="theProject.enroll" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>注册页面</title>
    <style>
    *
    {
        font: 13px/1.5 '微软雅黑', Verdana, Helvetica, Arial, sans-serif;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        -box-sizing: border-box;
        padding:0;
        margin:0;
        list-style:none;
    }
    body
    {
        background-image:url(images/login_bg1.jpg);
        background-repeat:no-repeat;
        background-position:center;
        background-size:cover;
        background-attachment:fixed;
    }
    body,html
    {
        width:100%;
        overflow:visible;
    }
    #titleName 
    {
        width:660px;
        margin: 0px 0 0 -18px;
        padding: 18px 10px 18px 60px;
        background: #27A9E3;
        position: relative;
        color: #fff;
        font-size: 16px;
    }
    #blackTri {
        background-image:url(images/blackTriangle.png);
        width: 18px;
        height: 10px;
        margin: 0 0 20px -18px;
        position: relative;
    }
    #userName,#passWord,#checkPassWord,#telNum,#QQNum
    {
        border: 1px solid #DCDEE0;
        vertical-align: middle;
        border-radius: 3px;
        height: 40px;
        padding: 0px 16px;
        font-size: 12px;
        color: #555555;
        outline:none;
        width:100%;
    }
    hr.hr15 {
        height: 10px;
        border: none;
        margin: 0px;
        padding: 0px;
        width: 100%;
    }
    hr.hr20 {
        height: 20px;
        border: none;
        margin: 0px;
        padding: 0px;
        width: 100%;
    }
    #submit1,#upload1,#fileUpload1
    {
        display: inline-block;
        vertical-align: middle;
        padding: 12px 24px;
        margin: 0px;
        font-size: 18px;
        line-height: 24px;
        text-align: center;
        white-space: nowrap;
        vertical-align: middle;
        cursor: pointer;
        color: #ffffff;
        background-color: #27A9E3;
        border-radius: 3px;
        border: none;
        -webkit-appearance: none;
        outline:none;
        width:100%;
    }
    #copyRight{
        font-size:14px;
        color:rgba(255,255,255,0.85);
        display:block;
        float:right;
        margin-bottom:15px;
        margin-right:15px;
    }
    a{
        color:#27A9E3;
        text-decoration:none;
        cursor:pointer;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main" style="width:660px;height:640px;background-color: #ffffff;margin:30px auto;border-radius: 4px;">
    <div id="blank" style="height:50px;">
        </div>
    <div id="titleName" >欢迎注册师大易物网</div>
    <div id="blackTri"></div>
        <div id="left" style="width:300px;background-color: #ffffff;float:left;margin:0 10px 20px 20px;border:1px solid #DCDEE0;border-radius: 4px;padding:10px;">
             <hr class="hr15"/>
            <asp:TextBox placeholder="用户名（1-10个字符）" ID="userName"  runat="server" AutoPostBack="True" OnTextChanged="userName_TextChanged" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <hr class="hr15"/>
            <asp:TextBox placeholder="密码（8-16个字符）" ID="passWord" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <hr class="hr15"/>
            <asp:TextBox placeholder="再输一遍" ID="checkPassWord" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <hr class="hr15" />
            <asp:TextBox placeholder="电话号码" ID="telNum" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <hr class="hr15"/>
            <asp:TextBox placeholder="QQ号码" ID="QQNum" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <hr class="hr15"/>
            <asp:TextBox placeholder="个人简介" ID="informText" runat="server" TextMode="MultiLine" style="width:100%;height:100px;border: 1px solid #DCDEE0;border-radius: 3px;padding: 5px 16px;font-size: 12px;color: #555555;" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <hr class="hr20"/>
            <asp:Button ID="submit1" runat="server" Text="提交" OnClick="submit1_Click" />
            <br />
            <a href="login.aspx"><<已注册,返回登录</a>
        </div>

        <div style="width:300px;background-color: #ffffff;float:right;margin:0px 20px 20px 0;border:1px solid #DCDEE0;border-radius: 4px;padding:10px;">
            <div style="width:200px;height:200px;margin:50px auto 30px;border:2px solid #DCDEE0 ">
                <asp:Image ID="userPhoto" runat="server" 
                    style="width:200px;height:200px;" 
                    ImageUrl="~/images/默认头像.png" ImageAlign="Left"/></div>
            <div style="margin:0 auto;width:70%;"><asp:FileUpload ID="fileUpload1" runat="server" style="width:100%;padding:6px 12px;font-size:12px;"/></div>
            <br />
            <div style="margin:0 auto;width:70%;"><asp:Button ID="upload1" runat="server" Text="上传头像" style="width:100%;padding:6px 12px;font-size:12px;" OnClick="upload1_Click"/></div>
        </div>
    </div>
    <div id="copyRight">©by大S211小组</div>
    </form>
</body>
</html>

