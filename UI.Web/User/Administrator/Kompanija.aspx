<%@ Page Title="" Language="C#" MasterPageFile="~/User/Administrator/Administrator.master" AutoEventWireup="true" CodeBehind="Kompanija.aspx.cs" Inherits="LearnByPractice.UI.Web.User.Administrator.Kompanija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministratorMainContentPlaceHolder" runat="server">
    <asp:DropDownList ID="ddlKompanija" runat="server" AutoPostBack="True" SelectionMode="Single" OnSelectedIndexChanged="ddlKompanija_SelectedIndexChanged">
        <asp:ListItem Value="0">Сите</asp:ListItem>
    </asp:DropDownList>
<asp:GridView ID="dgKompanija" runat="server" CellPadding="4" GridLines="None" Width="480px" AutoGenerateColumns="False" style="margin-left: 60px" ForeColor="#333333">
         <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Шифра" />
            <asp:BoundField DataField="Ime" HeaderText="Име на компанијата" />
            <asp:BoundField DataField="Adresa" HeaderText="Адреса" />
            <asp:BoundField DataField="KontaktTelefon" HeaderText="Контакт Тел." />
            <asp:BoundField DataField="vidOrganizacijaIme" HeaderText="Вид организација" />
            <asp:HyperLinkField  HeaderText="Веб страна" DataNavigateUrlFields="VebStrana" DataNavigateUrlFormatString="[0]" DataTextField="VebStrana" />
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
