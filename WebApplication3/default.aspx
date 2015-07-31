<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="BtnLista" runat="server" Text="Button" OnClick="BtnLista_Click" />
        <br />

        <asp:DropDownList ID="DdlTipoRestaurante" runat="server">
        </asp:DropDownList>
    
    </div>
        <asp:GridView ID="GdvPedidos" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#c0c0c0" BorderStyle="Solid" RowStyle-BackColor="#cccccc"
            >
            <Columns>
                <asp:BoundField DataField="DblApolice" HeaderText ="Apólice" />
                <asp:BoundField DataField="DtInicioVigencia" HeaderText ="Início Vigência Apólice" />
                <asp:BoundField DataField="DblSinistro" HeaderText ="Sinistro" />
                <asp:BoundField DataField="DtOcorrencia" HeaderText ="Data Ocorrência" />

            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
