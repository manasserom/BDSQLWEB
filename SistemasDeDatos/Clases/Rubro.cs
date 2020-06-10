using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class Rubro
    {
        int idRubro;
        string nombre;

        public Rubro()
        { }

        public int IdRubro { get => idRubro; set => idRubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}