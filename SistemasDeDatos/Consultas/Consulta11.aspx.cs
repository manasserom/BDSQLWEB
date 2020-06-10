using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NProveedor.Text = "";            
            ConexionBD con = new ConexionBD();
            List<Clases.proveedores> prov= new List<Clases.proveedores>();
            prov = con.Consulta11();


       


            foreach (var item in prov)
            {
                NProveedor.Text += item.Nombre + "<br/>";
                

            }
        }
    }
}