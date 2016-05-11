<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrirajSe.aspx.cs" Inherits="LearnByPractice.UI.Web.PublicPages.RegistrirajSe" Title="LearnByPractice - Регистрирај се" %>


<form id="registrirajSe" runat="server">
    <asp:radiobuttonlist id="RadioButtonList1" runat="server">
       <asp:ListItem>Администратор</asp:ListItem>
       <asp:ListItem>Ментор</asp:ListItem>
       <asp:ListItem>Студент</asp:ListItem>
    </asp:radiobuttonlist>
    <asp:label id="Ime" runat="server" text="Име "></asp:label>
    <asp:textbox id="txtIme" runat="server"></asp:textbox>
</form>

