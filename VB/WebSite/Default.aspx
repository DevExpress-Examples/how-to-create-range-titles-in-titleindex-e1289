<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
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
<dxti:Column></dxti:Column>
<dxti:Column></dxti:Column>
<dxti:Column></dxti:Column>
<dxti:Column></dxti:Column>
<dxti:Column></dxti:Column>
</Columns>
</dxti:aspxtitleindex>

	</div>
	</form>
</body>
</html>
