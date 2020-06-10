using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ConexionDB con = new ConexionDB();
          /*  foreach (Object item in con.consulta58("SELECT DISTINCT vendedores.nombre as Vendedor, r.nombre AS Rubro FROM vendedores, ventas AS v, productos as p, rubro AS r where NOT(vendedores.idVendedores = v.idVendedor AND v.idProducto = p.idProductos and p.idRubro = r.idRubro) ORDER BY vendedores.nombre ASC"))
            {
                Consulta.Text += Convert.ToString(item);
            }
           */
        }
    }
}