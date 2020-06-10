using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class vendedores
    {

        int idVendedores;
        string nombre, apellido, dni;

        public vendedores()
        {

        }

        public int IdVendedores { get => idVendedores; set => idVendedores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}