<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormView.aspx.cs" Inherits="WebApp2.TestControls.FormView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                DataObjectTypeName="WebApp2.TestControls.Car" DeleteMethod="Delete" 
                InsertMethod="Insert" SelectMethod="Select" 
                TypeName="WebApp2.TestControls.CarList" UpdateMethod="Update">
        </asp:ObjectDataSource>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Load Cars" 
            Style="z-index: 101; left: 20px; position: absolute; top: 45px" 
            onclick="Button1_Click" />
    </div>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
        DataKeyNames="Vin" DataSourceID="ObjectDataSource1" 
        EnableModelValidation="True" Width="100%">
        <ItemTemplate>
            <table>
            <tr>
                <td align="center">
                    <hr />
                    <span style="font-weight: bold; color: Blue">VIN:</span>&nbsp;
                    <asp:Label ID="VinLabel" Width="105px" runat="server" Text='<%# Eval("Vin") %>'></asp:Label>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Make:</span>&nbsp;
                    <asp:Label ID="MakeLabel" Width="105px" runat="server" Text='<%# Eval("Make") %>'></asp:Label>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Model:</span>&nbsp;
                    <asp:Label ID="ModelLabel" Width="105px" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Year:</span>&nbsp;
                    <asp:Label ID="YearLabel" Width="105px" runat="server" Text='<%# Eval("Year") %>'></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
             <td align="center">
                <span style="font-weight: bold; font-size: x-large">&nbsp;
                <asp:Label ID="PriceLabel" Width="105px" runat="server" Text='<%# Eval("Price", "{0:C}") %>'></asp:Label>
                </span>
             </td>
            </tr>

            </table>
        </ItemTemplate>
    </asp:FormView>
    </form>
</body>
</html>
