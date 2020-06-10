using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();

            foreach (var item in con.Consulta4())
            {
                Nombre.Text += item.Nombre + "<br/>";
                Precio.Text += item.Precio + "<br/>";
                Cantidad.Text += item.Cantidad + "<br/>";
            }
        }
    }
}