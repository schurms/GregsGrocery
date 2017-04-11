<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProducts.aspx.cs" Inherits="GregsGrocery.EditProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    ID:<asp:Label ID="lblID" runat="server" /> <br />
    Description<asp:TextBox ID="txtDesc" runat="server" /> <br />
    Price<asp:TextBox ID="txtPrice" runat="server" /> <br />
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /> <br />
    <asp:Button ID="btnDelete" runat="server" Text ="Delete" OnClick="btnDelete_Click" /> <br />
</asp:Content>
