<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lists.aspx.cs" Inherits="WebApp2.TestControls.Lists" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
