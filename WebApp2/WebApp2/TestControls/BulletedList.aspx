<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulletedList.aspx.cs" Inherits="WebApp2.TestControls.BulletedList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
        <asp:ListBox ID="ListBox1" runat="server" 
            onselectedindexchanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" 
            onselectedindexchanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
    </div>
    </form>
</body>
</html>
