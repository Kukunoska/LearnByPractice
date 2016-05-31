<%@ Page Title="" Language="C#" MasterPageFile="~/User/Administrator/Administrator.master" AutoEventWireup="true" CodeBehind="Tehnologija.aspx.cs" Inherits="LearnByPractice.UI.Web.User.Administrator.Tehnologija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministratorMainContentPlaceHolder" runat="server">
    <asp:DropDownList ID="ddlTehnologija" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTehnologija_SelectedIndexChanged" AppendDataBoundItems="true" >
        <asp:ListItem Value="0">Сите</asp:ListItem>
    </asp:DropDownList>
    <br/>
    <br>/
    <asp:GridView ID="dgTehnologija" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
        <asp:BoundField DataField="Id" HeaderText="Шифра" />
        <asp:BoundField DataField="Ime" HeaderText="Технологија" />
        <asp:BoundField DataField="oblastIme" HeaderText="Област" />
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
