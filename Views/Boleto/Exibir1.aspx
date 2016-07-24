<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exibir1.aspx.cs" Inherits="BoletoMVC.Views.Boleto.Exibir1" %>
<%@ Register Assembly="Impactro.Cobranca" Namespace="Impactro.WebControls" TagPrefix="cob" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exemplo Boleto</title>
    <style type="text/css">
		.BolCell { font-size: 7pt; FONT-FAMILY: Verdana }
	    .BolField { FONT-WEIGHT: bold; FONT-SIZE: 8pt; FONT-FAMILY: Verdana }
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cob:BoletoWeb id="bltPag" runat="server" CssCell="BolCell" CssField="BolField" ></cob:BoletoWeb>
    </div>
    </form>
</body>
</html>
