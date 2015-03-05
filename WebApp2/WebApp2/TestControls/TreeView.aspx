<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="WebApp2.TestControls.TreeView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
            DataFile="~/XmlData/Customers.xml"></asp:XmlDataSource>
        <asp:TreeView ID="TreeViewTest" runat="server" DataSourceID="XmlDataSource1" 
            onselectednodechanged="TreeViewTest_SelectedNodeChanged" ShowLines="True">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Customer" TextField="Name" 
                    ValueField="CustomerID" />
                <asp:TreeNodeBinding DataMember="Order" TextField="ShipDate" 
                    ValueField="OrderId" />
                <asp:TreeNodeBinding DataMember="OrderItem" TextField="PartDescription" 
                    ValueField="OrderItemId" />
                <asp:TreeNodeBinding DataMember="Invose" FormatString="{0:C}" 
                    TextField="Amount" ValueField="InvoceId" />
            </DataBindings>
        </asp:TreeView>
    </div>
    </form>
</body>
</html>
