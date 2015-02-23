<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="WebApp2.TestControls.MultiView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Button 1" onclick="Button1_Click" 
                Width="141px" /></asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Button ID="Button2" runat="server" Text="Button 2" onclick="Button2_Click" 
                    Width="197px" /></asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Button ID="Button3" runat="server" Text="Button 3" onclick="Button3_Click" 
                    Width="229px" /></asp:View>
        </asp:MultiView>
        
    </div>
    </form>
</body>
</html>
