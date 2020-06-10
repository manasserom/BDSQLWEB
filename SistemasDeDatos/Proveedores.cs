using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos
{
    public class Proveedores
    {
        string id, nombre, cuit;
        
        public Proveedores(string id, string nombre, string cuit)
        {
            this.id = id;
            this.nombre = nombre;
            this.cuit = cuit;
        }
    }
}