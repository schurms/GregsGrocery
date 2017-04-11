<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GregsGrocery._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>Product Name</td>
        <td>Product Price</td>
    </tr>
    <tr>
        <td><asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td>
    </tr>
    <asp:GridView ID="gvList" runat="server" OnSelectedIndexChanged="gvList_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</table>
</asp:Content>
