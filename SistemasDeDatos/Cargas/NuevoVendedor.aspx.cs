using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SistemasDeDatos.Cargas
{
    public partial class NuevoProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            ConexionBD con = new ConexionBD();

            string mensajex = con.CargaVendedor(Convert.ToString(Nombre.Text), Convert.ToString(Apellido.Text), Convert.ToString(DNI.Text));
            if (mensajex == "")
            {
                Mensaje.ForeColor = Color.Red;
                Mensaje.Text = "Error en la carga de Vendedores";
            }
            else
            {
                Mensaje.ForeColor = Color.Green;
                Mensaje.Text = "Se realizó la Carga con Éxito";
            }
        }
    }
}