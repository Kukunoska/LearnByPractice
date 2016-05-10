<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admnistrator.aspx.cs" Inherits="LearnByPractice.UI.Web.User.Admnistrator" MasterPageFile="~/WebSite.Master" Title="LearnByPractice - Администратор" %>

 <asp:Content runat="server" ContentPlaceHolderID="MainContentPlaceHolder" ID="MainContent">
        <div id ="DvidOrganizacija">
            <asp:Label ID="VidOrganizacijaNaslov" runat="server" Text="Видови Организации"></asp:Label> <br />
     <asp:Label ID="VidO" runat="server"></asp:Label><br /><br />
           </div>
      <div id ="Dorganizacija">
     <asp:Label ID="Organiz" runat="server"></asp:Label>
             </div>
      <div id ="DSP">
          <asp:Label ID="DspNaslov" runat="server" Text="Студиски програми" ></asp:Label><br/>
     <asp:Label ID="SP" runat="server"></asp:Label>
             </div>
 </asp:Content>

