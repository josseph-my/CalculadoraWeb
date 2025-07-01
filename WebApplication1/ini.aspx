<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ini.aspx.cs" Inherits="WebApplication1.ini" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style> 
        body{
            background-color:powderblue;
            text-align:center;
        }
        h1{
            color:palevioletred;
        }

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Calculadora </h1>

            <asp:Label id="result" Text="" runat="server" />
            <br />
            <label>Digite el numero 1</label>
            <asp:TextBox type="number" id="Tnum1" runat="server" />
            <br />
            <label>Digite el numero 2</label>
            <asp:TextBox type="number" id="Tnum2" runat="server" />
            <br />
            <br />
            <asp:DropDownList ID="List1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Sumar</asp:ListItem>
                <asp:ListItem>Restar</asp:ListItem>
                <asp:ListItem>Multiplicar</asp:ListItem>
                <asp:ListItem>Dividir</asp:ListItem>
                <asp:ListItem>Potencia 2</asp:ListItem>
                <asp:ListItem>Potencia 3</asp:ListItem>
                <asp:ListItem>Raiz cuadrada</asp:ListItem>
                <asp:ListItem>Factorial</asp:ListItem>
                <asp:ListItem>Fibonnaci</asp:ListItem>
            </asp:DropDownList>

            <br />
            <asp:Label id="pp" Text="" runat="server" />
            <br />
            <asp:Button ID="Bresult" Text="Calcular" runat="server" BackColor="#FFFF99" BorderColor="#FFCCCC" BorderStyle="Solid" Height="22px" OnClick="Bresult_Click" Width="60px" />
        </div>
    </form>
</body>
</html>
