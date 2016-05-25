<%@ Page Title="Learn By Practice - Администратор" Language="C#" MasterPageFile="~/User/Administrator/Administrator.master" AutoEventWireup="true" CodeBehind="VidOrganizacija.aspx.cs" Inherits="LearnByPractice.UI.Web.User.Administrator.VidOrganizacija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministratorMainContentPlaceHolder" runat="server">
     <asp:GridView ID="dgVidOrg" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" Width="480px" 
         style="margin-left: 60px" ForeColor="#333333">
         <AlternatingRowStyle BackColor="White" />
        <Columns>
        <asp:BoundField DataField="Id" HeaderText="Шифра" />
        <asp:BoundField DataField="Ime" HeaderText="Вид организација" />
        </Columns>
         <EditRowStyle BackColor="#7C6F57" />
         <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
         <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#E3EAEB" />
         <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#F8FAFA" />
         <SortedAscendingHeaderStyle BackColor="#246B61" />
         <SortedDescendingCellStyle BackColor="#D4DFE1" />
         <SortedDescendingHeaderStyle BackColor="#15524A" />
     </asp:GridView>
</asp:Content>
