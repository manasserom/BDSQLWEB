using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();
            List<Clases.proveedores> proveedores = new List<Clases.proveedores>();
            List<Clases.Productos> productos = new List<Clases.Productos>();

            productos = con.Consulta5(ref proveedores);

            foreach (var item in productos)
            {
                Producto.Text += item.Nombre + "<br/>";
                
            }
            foreach (var item2 in proveedores)
            {
                Proveedor.Text += item2.Nombre + "<br/>";
            }
        }
    }
}