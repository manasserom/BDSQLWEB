<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta7.aspx.cs" Inherits="SistemasDeDatos.Consultas.Consulta7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <div>
   <a runat="server" href="~/About">Volver</a>

    </div>
         
        <hr />
        <div style="height: 407px">
            <asp:Label ID="Label1" runat="server" Text="Ingrese Vendedor"></asp:Label>
             <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
          </asp:DropDownList>
            <br />
            <asp:Button ID="Button12" cssClass="btn btn-success" runat="server" Text="Buscar" OnClick="Button12_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <table class="table table-dark" border="2" style="width: 107%">
                <tr>
                    <td style="height: 20px; width: 124px;">Nombre</td>
                    <td style="height: 20px; width: 130px;">Apellido</td>
                    <td style="height: 20px; width: 367px;">Producto</td>
                    <td style="height: 20px; width: 12px;">Cantidad</td>
                    <td style="height: 20px">Total</td>
                </tr>
                <tr>
                    <td style="width: 124px">
                        <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="width: 130px">
                        <asp:Label ID="Apellido" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="modal-sm" style="width: 367px">
                        <asp:Label ID="Producto" runat="server" Text=""></asp:Label>
                    </td>
                    <td style="width: 12px">
                        <asp:Label ID="Cantidad" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Total" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
          </div>
</div>
</asp:Content>
