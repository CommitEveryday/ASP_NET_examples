﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WebApp2.TestControls.Calendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" ondayrender="Calendar1_DayRender" 
            onselectionchanged="Calendar1_SelectionChanged" 
            onvisiblemonthchanged="Calendar1_VisibleMonthChanged"></asp:Calendar>
    </div>
    </form>
</body>
</html>
