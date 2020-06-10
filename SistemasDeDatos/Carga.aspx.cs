using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasDeDatos
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConexionDB con = new ConexionDB();
           TextMensaje.Text=con.Insertar("INSERT INTO proveedores(`idProveedores`, `nombre`, `cuit`) VALUES(NULL, '"+Nombre.Text+"', '"+ Cuit.Text +"')") ;
        }
    }
}