<%@ Page Title="" Language="C#" MasterPageFile="~/User/Administrator/Administrator.master" AutoEventWireup="true" CodeBehind="Predmet.aspx.cs" Inherits="LearnByPractice.UI.Web.User.Administrator.Predmet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministratorMainContentPlaceHolder" runat="server">
     <asp:GridView ID="dgPredmet" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
        <asp:BoundField DataField="Id" HeaderText="Шифра" />
        <asp:BoundField DataField="ShifraNaPredmet" HeaderText="Шифра на предмет" />
        <asp:BoundField DataField="Ime" HeaderText="Име на предмет" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
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
