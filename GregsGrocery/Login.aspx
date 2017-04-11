﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GregsGrocery.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Label ID="lblInfo" runat="server" Text="Enter login details" />
                <table>
                    <tr>
                        <td>UserName:</td>
                        <td><asp:TextBox ID="txtUserName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Password:</td>
                        <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/></td>
                    </tr>
                </table>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
