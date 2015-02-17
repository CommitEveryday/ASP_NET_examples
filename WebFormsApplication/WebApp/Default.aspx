<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <p>
                <input runat="server" id="Button2" type="button" value="Click Click" /></p>

        </div>

        <input runat="server" id="Text1" type="text" />
        <p>
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        </p>

        <div runat="server" id="Div1">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Check" />
        </div>
        <div>
            <asp:Label runat="server" ID="LabelTest">LABEL!</asp:Label>
            <asp:Label ID="Label1" runat="server" Text="<u>Label</u>"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="93px" Width="262px"></asp:ListBox>
        <div runat="server" id="DivLiteral">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
