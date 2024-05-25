<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_1.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .container {
    width: 400px;
    margin:100px auto ;
    text-align: center;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 5px;
    }

    .form-container {
        margin-bottom: 20px;
    }

    .input-field {
        width: 100%;
        padding: 10px;
        margin-bottom: 10px;
        box-sizing: border-box;
    }

    .btn-container {
        text-align: center;
    }

    .login-btn {
        padding: 10px 20px;
        background-color: #007bff;
        color: #fff;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }

    .link-container {
        margin-top: 10px;
    }

    .link-container a {
        color: #007bff;
        text-decoration: none;
    }

    .link-container a:hover {
        text-decoration: underline;
    }
    .login-btn {
        background-color: #4CAF50;
        border: none;
        color: white;
    padding: 12px 24px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    border-radius: 7px;
}
h2 {
    background-color: #0077b6;
    color: white;
    text-align: center;
    padding: 10px 20px;
    display: inline-block;
    border-radius: 20px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>&nbsp;&nbsp;&nbsp;Login&nbsp;&nbsp;&nbsp; </h2>
            <div class="form-container">
                <div>
                    <label for="txtUsername">Username:</label>
                    <asp:TextBox ID="cAccountText" runat="server" CssClass="input-field" Width="300px"></asp:TextBox>
                </div>
                <div>
                    <label for="txtPassword">Password:</label>
                    <asp:TextBox ID="cPasswordText" runat="server" TextMode="Password" CssClass="input-field" Width="300px"></asp:TextBox>
                </div>
               

                <div class="btn-container">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="login-btn" />
                </div>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </div>
            <div class="link-container">
                <a href="#" style="font-size:20px;">忘記帳號</a> <!-- 忘記帳號的連結 -->
            </div>
        </div>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        </asp:PasswordRecovery>

        
            <video width="320" height="240" controls>
  <source src="test.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>
    </form>
</body>
</html>
<%-- <div>
                    <label for="txtCaptcha">驗證碼:</label>
                    <asp:TextBox ID="txtCaptcha" runat="server" CssClass="input-field" Width="200px"></asp:TextBox>
                    <asp:Image ID="imgCaptcha" runat="server" />
                    <asp:Button ID="btnRefreshCaptcha" runat="server" Text="刷新" OnClick="btnRefreshCaptcha_Click" />
                </div>--%>