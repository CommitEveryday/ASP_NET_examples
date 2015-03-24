﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDataTable.aspx.cs" Inherits="WebApp2.TestADO.NET.WebFormDataTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Get and Bind DataTable" 
            onclick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="DataRowVersion" />
        <br />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Copy DataTable" />
        <br />
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
            Text="Clone DataTable and ImportRow" />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Create Employee XML File" />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Create Formatted XML File" />
        <br />
        <asp:Button ID="Button7" runat="server" Text="Create XML File w/Schema" />
        <br />
        <asp:Button ID="Button8" runat="server" Text="Read XML File w/Schema" />
        <br />
        <asp:Button ID="Button9" runat="server" Text="Sort With DataView" />
    </div>
    </form>
</body>
</html>
