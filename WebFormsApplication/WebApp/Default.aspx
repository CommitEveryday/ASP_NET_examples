<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p><input runat="server"  id="Button2" type="button" value="Click Click" /></p>

    </div>
        
        <input runat="server" id="Text1" type="text" /><p>
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        </p>
        
    </form>
    <div runat="server" id="Div1">
        </div>
</body>
</html>
