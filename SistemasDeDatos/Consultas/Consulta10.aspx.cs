using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NProducto.Text = "";
            CProducto.Text = "";
            PProducto.Text = "";
            ConexionBD con = new ConexionBD();
            List<Clases.Productos> productos = new List<Clases.Productos>();
            productos = con.Consulta10(Nombre.Text);





            foreach (var item in productos)
            {
                NProducto.Text += item.Nombre + "<br/>";
                CProducto.Text += item.Cantidad + "<br/>";
                PProducto.Text += item.Precio + "<br/>";

            }

        }
    }
}