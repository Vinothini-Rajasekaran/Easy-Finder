<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
 
      <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1 align="center" class="color">Easy Finder!!</h1>
    <h2 align="center">Login</h2>
<div class="login-page">
  <div class="form">
    <form class="login-form" action="WebForm1.aspx" runat="server">
        <asp:Image ID="Books" ImageUrl="~/lotsofbooks.gif" runat="server" Width="104px" />

        <asp:TextBox  class="field" placeholder="Username" runat="server" ID="username" required></asp:TextBox>
        
             <asp:TextBox class="field" placeholder="Password" runat="server" ID="password" required></asp:TextBox>
      <asp:button class="btn" runat="server" placeholder="login" Text="Login" ID="login"></asp:button>

    </form>
  </div>
</div>


</body>
</html>
