<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTitleIndex" TagPrefix="dxti" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Customers]"></asp:AccessDataSource>
        <dxti:aspxtitleindex id="ASPxTitleIndex1" runat="server" groupingfield="GroupText"
            navigateurlfield="ID" navigateurlformatstring="?id={0}" textfield="ContactName">
<FilterBox Visible="False"></FilterBox>
<Columns>
<dxti:TitleIndexColumn></dxti:TitleIndexColumn>
<dxti:TitleIndexColumn></dxti:TitleIndexColumn>
<dxti:TitleIndexColumn></dxti:TitleIndexColumn>
<dxti:TitleIndexColumn></dxti:TitleIndexColumn>
<dxti:TitleIndexColumn></dxti:TitleIndexColumn>
</Columns>
</dxti:aspxtitleindex>
    
    </div>
    </form>
</body>
</html>
