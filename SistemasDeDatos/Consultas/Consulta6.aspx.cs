using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();
            List<Clases.vendedores> vendedores = new List<Clases.vendedores>();
            List<Clases.Productos> productos = new List<Clases.Productos>();
            List<Clases.ventas> ventas = new List<Clases.ventas>();
            productos = con.Consulta6(ref vendedores, ref ventas);

            foreach (var item in productos)
            {
                Producto.Text += item.Nombre + "<br/>";
               

            }
            foreach (var item2 in vendedores)
            {
                Nombre.Text += item2.Nombre + "<br/>";
                Apellido.Text += item2.Apellido + "<br/>";
            }

            foreach (var item2 in ventas)
            {
                Cantidad.Text += item2.Cantidad + "<br/>";
                Total.Text += item2.MontoTotal + "<br/>";
               
            }
        }
    }
}