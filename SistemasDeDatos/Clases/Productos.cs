using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class Productos
    {
        int idProducto, precio, cantidad, rubro;
        string nombre;

        public Productos()
        {

        }
        public Productos(int idProducto, string nombre, int precio, int cantidad, int rubro)
        {
            this.IdProducto = idProducto;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Rubro = rubro;
            this.Nombre = nombre;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Rubro { get => rubro; set => rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}