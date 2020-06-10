<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoRubro.aspx.cs" Inherits="SistemasDeDatos.Cargas.NuevoRubro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/Contact">Volver</a>
    </div>
        <hr style="width: 822px" />
        <div style="height: 181px; width: 821px; margin-left: 280px;">
            <asp:Label ID="Label1" runat="server" Text="Ingrese Nuevo Rubro"></asp:Label>
            <br />
            <asp:TextBox ID="RubroNombre" class="form-control" runat="server" Width="231px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" cssClass="btn btn-success" runat="server" Text="Cargar" OnClick="Button8_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Mensaje" runat="server" Text=""></asp:Label>
          </div>
    </div>
</asp:Content>
