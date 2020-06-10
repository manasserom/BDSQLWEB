using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SistemasDeDatos.Cargas
{
    public partial class NuevoRubro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();
            string nombre = Convert.ToString(RubroNombre.Text);
            Mensaje.Text = con.CargaRubro(nombre);
            if(Mensaje.Text=="")
            {
                Mensaje.ForeColor = Color.Red;
                Mensaje.Text = "Error en la carga de Rubro";
            }
            else
            {
                Mensaje.ForeColor = Color.Green;
                Mensaje.Text = "Se realizó la Carga con Éxito";
            }



        }
    }
}