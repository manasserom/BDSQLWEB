using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class ventas
    {

        int idVentas, cantidad, montoTotal, idVendedor, idProducto;

        public ventas()
        {

        }

        public int IdVentas { get => idVentas; set => idVentas = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
    }
}