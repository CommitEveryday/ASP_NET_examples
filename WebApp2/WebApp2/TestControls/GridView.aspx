<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="WebApp2.TestControls.GridView" %>

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
            <InsertParameters>
                <asp:Parameter Name="vin" Type="String" />
                <asp:Parameter Name="make" Type="String" />
                <asp:Parameter Name="model" Type="String" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="price" Type="Decimal" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" 
            Style="z-index: 100; left: 20px; position: absolute; top: 75px"
            AllowPaging="True" 
            AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Vin" 
            DataSourceID="ObjectDataSource1" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" Width="135px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="Vin" HeaderText="VIN" SortExpression="Vin" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" 
                    DataFormatString="{0:#.}" HtmlEncode="False" ApplyFormatInEditMode="True" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Load Cars" 
            Style="z-index: 102; left: 20px; position: absolute; top: 45px" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
