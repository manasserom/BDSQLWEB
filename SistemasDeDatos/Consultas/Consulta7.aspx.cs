using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SistemasDeDatos.Consultas
{
    public partial class Consulta7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList1.Items.Clear();
            if (Page.IsPostBack!=true)
            {
                ConexionBD con = new ConexionBD();
                ListItem lista;
                foreach (String item in con.ConsultaVendedores2Spinner())
                {
                    lista = new ListItem(item);
                    DropDownList1.Items.Add(lista);
                }
            }
            
            
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Producto.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
            Cantidad.Text = "";
            Total.Text = "";
            ConexionBD con = new ConexionBD();
            List<Clases.vendedores> vendedores = new List<Clases.vendedores>();
            List<Clases.Productos> productos = new List<Clases.Productos>();
            List<Clases.ventas> ventas = new List<Clases.ventas>();
            productos = con.Consulta7(ref vendedores, ref ventas,DropDownList1.Text);
           
           
          
            
            
                foreach (var item in productos)
                {
                    Producto.Text += item.Nombre + "<br/>";


                }
                foreach (var item2 in vendedores)
                {
                    Nombre.Text += item2.Nombre + "<br/>";
                    Apellido.Text += item2.Apellido + "<br/>";
                }

                foreach (var item2 in ventas)
                {
                    Cantidad.Text += item2.Cantidad + "<br/>";
                    Total.Text += item2.MontoTotal + "<br/>";

                }
            
            
        }

        
    }
}