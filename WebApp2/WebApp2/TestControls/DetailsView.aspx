<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsView.aspx.cs" Inherits="WebApp2.TestControls.DetailsView" %>

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
        <asp:Button ID="Button1" runat="server" Text="Load Cars" 
            Style="z-index: 101; left: 20px; position: absolute; top: 45px" 
            onclick="Button1_Click" />
        <asp:DetailsView ID="DetailsView1" runat="server" 
            Style="z-index: 103; left: 20px; position: absolute; top: 85px"
            AllowPaging="True" 
            AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Vin" 
            DataSourceID="ObjectDataSource1" 
            ForeColor="#333333" GridLines="None" 
            Height="50px" Width="305px" EnableModelValidation="True" 
            AutoGenerateRows="False">
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Fields>
                <asp:BoundField DataField="Vin" HeaderText="Vin" SortExpression="Vin" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" 
                    DataFormatString="{0:#.}" HtmlEncode="False" ApplyFormatInEditMode="True" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
