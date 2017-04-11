<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewSale.aspx.cs" Inherits="GregsGrocery.NewSale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Gridview ID="gvList" runat="server" OnSelectedIndexChanged="gvList_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:Gridview>
    Quantity: <asp:TextBox ID="txtQuantity" runat="server" />
</asp:Content>
