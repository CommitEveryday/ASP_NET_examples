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
                <span style="font-weight: bold; font-size: large; color: Blue">Цена: </span>
                <span style="font-weight: bold; font-size: x-large">&nbsp;
                <asp:Label ID="PriceLabel" Width="105px" runat="server" Text='<%# Eval("Price", "{0:C}") %>'></asp:Label>
                </span>
             </td>
            </tr>
            <tr>
             <td align="center">
                <hr />
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="Edit" Text="Edit">
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandName="New" Text="New">
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="false" CommandName="Delete" Text="Delete">
                </asp:LinkButton>
             </td>
            </tr>
            </table>
        </ItemTemplate>

        <EditItemTemplate>
            <table>
            <tr>
                <td align="center">
                    <hr />
                    <span style="font-weight: bold; color: Blue">VIN:</span>&nbsp;
                    <asp:Label ID="VinLabel" Width="105px" runat="server" Text='<%# Eval("Vin") %>'></asp:Label>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Make:</span>&nbsp;
                    <asp:TextBox ID="EditMakeTextBox" Width="100px" runat="server" Text='<%# Bind("Make") %>'></asp:TextBox>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Model:</span>&nbsp;
                    <asp:TextBox ID="EditModelTextBox" Width="100px" runat="server" Text='<%# Bind("Model") %>'></asp:TextBox>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Year:</span>&nbsp;
                    <asp:TextBox ID="EditYearTextBox" Width="100px" runat="server" Text='<%# Bind("Year") %>'></asp:TextBox>
                    <br />&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
             <td align="center">
                <span style="font-weight: bold; font-size: large; color: Blue">Цена: </span>
                <span style="font-weight: bold; font-size: large">&nbsp;
                <asp:TextBox ID="EditPriceTextBox" 
                    Width="100px" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
                </span>
             </td>
            </tr>
            <tr>
             <td align="center">
                <hr />
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update">
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel">
                </asp:LinkButton>
             </td>
            </tr>
            </table>
        </EditItemTemplate>

        <EmptyDataTemplate>
            <table width="655px">
                <tr>
                    <td align="center">
                        <hr />
                        <span style="font-weight: bold; font-size: large; color: Blue">No cars!</span>
                    </td>
                </tr>
                <tr>
             <td align="center">
                <hr />
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="New" Text="New">
                </asp:LinkButton>
             </td>
            </tr>
            </table>
        </EmptyDataTemplate>

        <InsertItemTemplate>
            <table>
            <tr>
                <td align="center">
                    <hr />
                    <span style="font-weight: bold; color: Blue">VIN:</span>&nbsp;
                    <asp:TextBox ID="InsertVinTextBox" Width="105px" runat="server" Text='<%# Bind("Vin") %>'></asp:TextBox>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Make:</span>&nbsp;
                    <asp:TextBox ID="InsertMakeTextBox" Width="100px" runat="server" Text='<%# Bind("Make") %>'></asp:TextBox>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Model:</span>&nbsp;
                    <asp:TextBox ID="InsertModelTextBox" Width="100px" runat="server" Text='<%# Bind("Model") %>'></asp:TextBox>
                    &nbsp;&nbsp;
                    <span style="font-weight: bold; color: Blue">Year:</span>&nbsp;
                    <asp:TextBox ID="InsertYearTextBox" Width="100px" runat="server" Text='<%# Bind("Year") %>'></asp:TextBox>
                    <br />&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
             <td align="center">
                <span style="font-weight: bold; font-size: large; color: Blue">Цена: </span>
                <span style="font-weight: bold; font-size: large">&nbsp;
                <asp:TextBox ID="InsertPriceTextBox" 
                    Width="100px" runat="server" Text='<%# Bind("Price") %>'></asp:TextBox>
                </span>
             </td>
            </tr>
            <tr>
             <td align="center">
                <hr />
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert">
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel">
                </asp:LinkButton>
             </td>
            </tr>
            </table>
        </InsertItemTemplate>

        <HeaderTemplate>
        <table>
            <tr>
            <td align="center">
                <span style="font-weight: bold; font-size: x-large; color: Blue">Car For Sale</span>
            </td>
            </tr>
        </table>
        </HeaderTemplate>

    </asp:FormView>
    </form>
</body>
</html>
