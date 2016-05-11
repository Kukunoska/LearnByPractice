<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="LearnByPractice.UI.Web.PublicPages.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LogIn</title>
</head>
<body>
    <form id="form1" runat="server">
<div>
<table>
<tr>
<td>
Username:
</td>
<td>
<asp:TextBox ID="txtUserName" runat="server"/>
</td>
</tr>
<tr>
<td>
Password:
</td>
<td>
<asp:TextBox ID="txtPWD" runat="server" TextMode="Password"/>
</td>
</tr>
</table>
</div>
</form>
</body>
</html>
