using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SistemasDeDatos.Cargas
{
    public partial class NuevoProducto : System.Web.UI.Page
    {
        int idRubro;
        protected void Page_Load(object sender, EventArgs e)
        {
            ListItem lista;
            ConexionBD con = new ConexionBD();

            foreach (String item in con.ConsultaRubroSpinner())
            {
                lista = new ListItem(item);
                ListaRubros.Items.Add(lista);
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            ConexionBD con = new ConexionBD();

            List<Clases.Rubro> ListaRubro = new List<Clases.Rubro>();
            ListaRubro = con.ConsultaRubroCarga();
            

            foreach (var item in ListaRubro)
            {
                if (item.Nombre.Equals(Convert.ToString(ListaRubros.Text)))
                {
                    idRubro = item.IdRubro;
                }

            }


          
            Mensaje.Text = con.CargaProducto(Nombre.Text,Convert.ToInt32(Precio.Text),Convert.ToInt32(Cantidad.Text),idRubro);
            if (Mensaje.Text == "")
            {
                Mensaje.ForeColor = Color.Red;
                Mensaje.Text = "Error en la carga de Producto";
            }
            else
            {
                Mensaje.ForeColor = Color.Green;
                Mensaje.Text = "Se realizó la Carga con Éxito";
            }





        }
    }
}