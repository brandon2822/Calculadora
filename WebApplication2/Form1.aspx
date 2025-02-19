<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="WebApplication2.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora</h2>
            <br />
            <br />
            <asp:Label ID="lResultado" runat="server" Text="Resultado 1"></asp:Label>
            <br />
            <br />
            <label>Digite un numero: </label>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <label>Digite un segundo numero: </label>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOperacion" runat="server" Text="Calcular" OnClick="btnOperacion_Click" />
            <br />
            <br />
            <asp:RadioButton  ID="Suma" runat="server" GroupName="radioBtn" Text="Suma" />
            <asp:RadioButton  ID="Resta" runat="server" GroupName="radioBtn" Text="Resta" />
            <asp:RadioButton  ID="Division" runat="server" GroupName="radioBtn" Text="Division" />
            <asp:RadioButton  ID="Multiplicacion" runat="server" GroupName="radioBtn" Text="Multiplicacion" />
            <br />
            <br />
             <asp:Label ID="lResultado2" runat="server" Text="Resultado 2"></asp:Label>
            <br />
            <br />
            <label>Digite un numero: </label>
            <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
            <label>Digite un segundo numero: </label>
            <asp:TextBox ID="txtNum4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOperacion2" runat="server" Text="Calcular" OnClick="btnOperacion2_Click" />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
             </asp:DropDownList>
             <br />
             <br />
              <asp:Label ID="lResultado3" runat="server" Text="Resultado 3"></asp:Label>
             <br />
             <br />
             <label>Digite un numero: </label>
             <asp:TextBox ID="txtNum5" runat="server"></asp:TextBox>
             <label>Digite un segundo numero: </label>
             <asp:TextBox ID="txtNum6" runat="server"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="btnOperacion3" runat="server" Text="Calcular" OnClick="btnOperacion3_Click" />
             <br />
             <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Suma" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Resta"/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Multiplicacion"/>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Division"/>
            <br />
            <br />
             <asp:Label ID="lResultado4" runat="server" Text="Resultado 4"></asp:Label>
            <br />
            <br />
            <label>Digite un numero: </label>
            <asp:TextBox ID="txtNum7" runat="server"></asp:TextBox>
            <label>Digite un segundo numero: </label>
            <asp:TextBox ID="txtNum8" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOperacion4" runat="server" Text="Calcular" OnClick="btnOperacion4_Click" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="Suma"></asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>

        </div>
    </form>
</body>
</html>
