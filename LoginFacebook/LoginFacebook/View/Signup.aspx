<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="LoginFacebook.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
   <link href="https://fonts.googleapis.com/css?family=Open+Sans:300" rel="stylesheet" />
    <link href="CSS/signup.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title></title>
</head>
<body >
      <nav class="header">
        <ul>
            <li><a href="Login.aspx">Home</a></li>
            <li><a href="#">####</a></li>
            <li><a href="#">####</a></li>
            <li><a href="#">####</a></li>
        </ul>

    </nav>
    <div class="container">
        <asp:Label ID="lblSignUp" class="lbl" runat="server" Text="Sign Up"></asp:Label>
        <br />
        <br />
        <form id="form1" runat="server">
            <div class="formclass">
                <asp:TextBox ID="txtName" CssClass="input" runat="server" placeholder="Name"></asp:TextBox>
                <br/>
                <asp:TextBox ID="txtLastName" CssClass="input" runat="server" placeholder="Last Name"></asp:TextBox>
                <br/>
                <asp:TextBox ID="txtEmail"  CssClass="input" runat="server" placeholder="E-mail"></asp:TextBox>
                <br/>
                <asp:TextBox ID="txtPass" CssClass="input" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                <br/>
                <asp:TextBox ID="txtRePass" CssClass="input" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                <br/>
                <asp:Button ID="btnSubmit" CssClass="btn-login" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </div>
    <div class="footer">
        Copyright 2017 | Celeste Fernández | BLUESOFT
        </div>
</body>
</html>
