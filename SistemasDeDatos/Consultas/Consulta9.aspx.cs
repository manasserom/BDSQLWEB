using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NVendedor.Text = "";
            NRubro.Text = "";
            ConexionBD con = new ConexionBD();
            List<Clases.vendedores> vendedores = new List<Clases.vendedores>();
            List<Clases.Rubro> rubro = new List<Clases.Rubro>();
            rubro = con.Consulta9(ref vendedores);





            foreach (var item in vendedores)
            {
                NVendedor.Text += item.Nombre + "<br/>";

            }
            foreach (var item2 in rubro)
            {
                NRubro.Text += item2.Nombre + "<br/>";

            }
        }
    }
}