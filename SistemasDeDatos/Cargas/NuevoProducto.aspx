<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoProducto.aspx.cs" Inherits="SistemasDeDatos.Cargas.NuevoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <p>
        <br />
    </p>
    <div>
          <a runat="server" href="~/Contact">Volver</a>
       
    </div>
        <hr />
        <div style="height: 441px; margin-left: 280px;">
            <asp:Label ID="Label1" runat="server" Text="Nombre del Nuevo Producto"></asp:Label>
            <asp:TextBox ID="Nombre" class="form-control" runat="server" Width="436px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Precio del Nuevo Producto"></asp:Label>
            <asp:TextBox ID="Precio" class="form-control" runat="server" Width="436px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cantidad del Nuevo Producto"></asp:Label>
            <asp:TextBox ID="Cantidad" class="form-control" runat="server" Width="435px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Rubro del Nuevo Producto"></asp:Label>
            <asp:DropDownList ID="ListaRubros" class="form-control" runat="server" Width="459px">
            </asp:DropDownList>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" class="btn btn-success" runat="server" Text="Cargar" OnClick="Button8_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Mensaje" runat="server" Text=""></asp:Label>
          </div>
</div>
</asp:Content>
