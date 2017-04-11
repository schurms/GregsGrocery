<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sales.aspx.cs" Inherits="GregsGrocery.Sales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:DropDownList ID="ddlSelectSale" runat="server" />
            </td>
            <td>
                <asp:Button ID="btnSelectSale" runat="server" Text="Select" OnClick="btnSelectSale_Click" />
            </td>
        </tr>
        <tr>
            <asp:GridView ID="gvList" runat="server">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Table ID="tblTest" runat="server">

            </asp:Table>
        </tr>
        <tr>
            <td>
                Product Price: <asp:TextBox ID="txtProductPrice" runat="server" />
            </td>
            <td>
                Quantity: <asp:TextBox ID="txtQuantity" runat="server" />
            </td>
            <td>
                <asp:Button ID="btnBuy" runat="server" Text="Buy" OnClick="btnBuy_Click" />
            </td>
        </tr>
        <tr>
            <td>
                New Sale: <asp:Button ID="btnNew" runat="server" Text="new" OnClick="btnNew_Click" />
            </td>
        </tr>

    </table>
</asp:Content>
