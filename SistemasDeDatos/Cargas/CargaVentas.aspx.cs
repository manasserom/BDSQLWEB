using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SistemasDeDatos
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int vendedor;
        static List<Clases.ventas> ListaVentas = new List<Clases.ventas>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                ListItem lista,lista2;
                ConexionBD con = new ConexionBD();

                foreach (String item in con.ConsultaProductos())
                {
                    lista = new ListItem(item);
                    ListProducto.Items.Add(lista);
                }

                foreach (String item in con.ConsultaVendedoresSpinner())
                {
                    lista2 = new ListItem(item);
                    ListaVendedor.Items.Add(lista2);
                }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }





        protected void Button8_Click1(object sender, EventArgs e) //Boton Carga
        {
            ConexionBD con = new ConexionBD();
            string mensaje = "";
            if(ListaVentas!=null)
            { 
            foreach (var item in ListaVentas)
            {

                mensaje=con.CargaVentas(item.IdVentas, item.Cantidad, item.MontoTotal, item.IdVendedor, item.IdProducto);


            }

           
            if(mensaje!="")
            {
                MensajeError.Text = "";
                MensajeCarga.ForeColor = Color.Green;
                MensajeCarga.Text = "Se realizó la venta con Éxito";
            }
            else
            {
                MensajeError.Text = "";
                MensajeCarga.ForeColor = Color.Red;
                MensajeCarga.Text = "NO SE INGRESARON PRODUCTOS";
            }
            }
            else
            {
                MensajeError.Text = "";
                MensajeCarga.ForeColor = Color.Red;
                MensajeCarga.Text = "VERIFIQUE EL INGRESO DE PRODUCTOS";
            }
            

        }




        protected void Button9_Click(object sender, EventArgs e) //Boton Cargar Producto
        {

            List<Clases.Productos> List = new List<Clases.Productos>();
            ConexionBD con = new ConexionBD();
            List = con.ConsultaProductosCarga();
            List<Clases.vendedores> ListaVendedores = new List<Clases.vendedores>();
            ListaVendedores = con.ConsultaVendedoresCarga();
            
            if(CantidadBox.Text=="")
            {
                MensajeError.Text = "VERIFIQUE EL CAMPO CANTIDAD";
                return;
            }

            foreach (var item in ListaVendedores)
            {
                if (item.Nombre.Equals(Convert.ToString(ListaVendedor.Text)))
                {
                    vendedor = item.IdVendedores;
                }
            }
    
            foreach (var item in List)
            {
                if (item.Nombre.Equals(Convert.ToString(ListProducto.Text)))
                {
                   
                    codigo.Text += item.IdProducto + "<br/>" ;
                    Descripcion.Text += item.Nombre + "<br/>";
                    PrecioU.Text += "$ " + item.Precio + "<br/>";
                    Cantidad.Text += CantidadBox.Text + "<br/>";
                    Total.Text += "$ " + (Convert.ToInt32(item.Precio) * Convert.ToInt32(CantidadBox.Text)) + "<br/>";

                    Clases.ventas ventas = new Clases.ventas();
                    ventas.IdVentas =0 ;
                    ventas.Cantidad = Convert.ToInt32(CantidadBox.Text);
                    ventas.MontoTotal = (Convert.ToInt32(item.Precio) * Convert.ToInt32(CantidadBox.Text));
                    ventas.IdVendedor = vendedor;
                    ventas.IdProducto = item.IdProducto;

                    ListaVentas.Add(ventas);

                   
                    MensajeError.Text = "";

                }

            }
           

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            codigo.Text = "";
            Descripcion.Text = "";
            PrecioU.Text = "";
            Cantidad.Text = "";
            Total.Text = "";
            ListaVentas = null;
        }
    }
}