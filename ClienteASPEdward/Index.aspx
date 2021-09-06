<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClienteASPEdward.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cliente ASP Net - Acceso al Servis de Some de Reniec</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Listado de Ciudadanos" Font-Size="Larger" ForeColor="Red"></asp:Label>
            </p>
            <p>
                Ingrese DNI: <asp:TextBox runat="server" ID="txtDNI" />
            
                <asp:Button Text="Consultar DNI" runat="server" ID="btnConsultar" OnClick="btnConsultar_Click" />
            </p>
            <p>
                <p>
                Ingrese Direccion: <asp:TextBox runat="server" ID="TextDireccion" />
            
                <asp:Button Text="Consultar Direccion" runat="server" ID="btnDireccion" OnClick="btnDireccion_Click" />
            </p>
            <p>
                <asp:GridView runat="server" ID="gvDatosDNI" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
