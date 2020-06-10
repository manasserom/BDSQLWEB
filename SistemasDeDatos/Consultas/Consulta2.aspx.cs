using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ConexionBD con = new ConexionBD();

            foreach (var item in con.Consulta2())
            {
                Nombre.Text += item.Nombre + "<br/>";
                Apellido.Text += item.Apellido+ "<br/>";
                Dni.Text += item.Dni + "<br/>";
            }




        }
    }
}