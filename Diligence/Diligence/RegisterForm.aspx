<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="Diligence.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link rel="stylesheet" type="text/css" href="Register.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 
</head>
<body>
    <%--html代码--%>
    <form id="form1" runat="server">
        <%--背景图片--%>
        <div>
            <img src="Images/RegisterBackImage.png" class="backImg"/>
        </div>
         <div class="title">
            <h2>欢迎来到铁一中登录界面</h2>
        </div>
        <div class="contain">
            <img style="width:40px;height:40px;position:absolute;left:180px;top:110px;opacity:0.4;background-color:white;" src="Images/userpic.jpg" />
            <asp:TextBox ID="zhanghao" runat="server" placeholder="请输入账号" ></asp:TextBox>
            <input id="pwd" type="password" placeholder="请输入密码"/>
           
            <label class="show" style="position:absolute;top:320px;right:120px;">显示密码</label>
            <asp:TextBox ID="reg" runat="server" placeholder="输入有图中的验证码"></asp:TextBox>
            <img alt="" src="yzm.aspx" id="Image1"/>
            <asp:Button ID="btn" runat="server" Text="登录" />
             
        </div>

        <%--//js代码--%>
        <script src="JS/jquery-3.3.1.js"></script>
        <script type="text/javascript">
           
            var pass = $('#pwd');
                var i = 0;
            ////显示密码
            $('.show').click(function () {

                $('.show').click(function () {
                    i++;
                    if (i % 2 == 0) {
                        $('#pwd').attr("type", 'text');

                    }

                    else {
                        $('#pwd').attr("type", 'password');

                    }
                });


            });
            //控件检测
        
            $('#btn').click(function () {
                if ($('#zhanghao').val() == "") {
                    alert("账号未填!");
                    return false;
           
                }
                else if ($('#pwd').val() == "") {
                    alert("密码未填!");
                    return false;
           
                }
                 else if ($('#reg').val() == "") {
                    alert("验证码未填!");
                    return false;
           
                }
            });
            
           
            
        </script>
    </form>

</body>
</html>
