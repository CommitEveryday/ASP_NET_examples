<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspControlTest.aspx.cs" Inherits="WebApp.AspControlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label ID="Label1" runat="server" Text="MyLabel"></asp:Label></div>
        <div><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
        <div><asp:Button ID="Button1" runat="server" Text="MyButton" OnClick="Button1_Click" /></div>
        <div><asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="MyCheckBox" /></div>
        <div><asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="MyGroup" OnCheckedChanged="RadioChanged" Text="MyRadioButton1" /></div>
        <div><asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="MyGroup" OnCheckedChanged="RadioChanged" Text="MyRadioButton2" /></div>
        <div><asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" GroupName="MyGroup" OnCheckedChanged="RadioChanged" Text="MyRadioButton3" /></div>
    </form>
</body>
</html>
