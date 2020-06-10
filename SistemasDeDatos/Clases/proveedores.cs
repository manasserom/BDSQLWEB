using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class proveedores
    {

        int idProveedores;
        string nombre, cuit;

        public proveedores()
        {
            

        }

        public int IdProveedores { get => idProveedores; set => idProveedores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuit { get => cuit; set => cuit = value; }
    }
}