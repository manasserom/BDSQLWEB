using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos.Clases
{
    public class compras
    {
        int idCompras, idProveedor, idProductos, Cantidad, montoTotal;

        
        public compras(int idCompras, int idProveedor, int idProductos, int Cantidad, int montoTotal)
        {
            this.idCompras = idCompras;
            this.idProveedor = idProveedor;
            this.idProductos = idProductos;
            this.Cantidad = Cantidad;
            this.montoTotal = montoTotal;
        }


    }
}