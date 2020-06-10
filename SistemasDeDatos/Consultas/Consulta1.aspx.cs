using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ConexionBD con = new ConexionBD();

            foreach (var item in con.Consulta1())
            {
                Nombre.Text += item.Nombre + "<br/>";
                Cuit.Text += item.Cuit + "<br/>";
            }




        }
    }
}