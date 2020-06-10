using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NProveedor.Text = "";
            NRubro.Text = "";
            ConexionBD con = new ConexionBD();
            List<Clases.proveedores> proveedores = new List<Clases.proveedores>();
            List<Clases.Rubro> rubro = new List<Clases.Rubro>();
            proveedores = con.Consulta8(ref rubro);





            foreach (var item in proveedores)
            {
                NProveedor.Text += item.Nombre + "<br/>";
                
            }
            foreach (var item2 in rubro)
            {
                NRubro.Text += item2.Nombre + "<br/>";
              
            }

        
        }
    }
}