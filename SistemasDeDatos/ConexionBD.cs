using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace SistemasDeDatos
{
    public class ConexionBD
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);


        public ConexionBD()
        {
            //test 2
        }



        public string Test()
        {
            try
            {

                databaseConnection.Open();

                databaseConnection.Close();
                return ("Conexión establecida con éxito");

            }
            catch (Exception)
            {
                return ("Conexión establecida SIN éxito");
                
            }

        }

        public string CargaVendedor(string nombre,string apellido, string dni)
        {
            string query = "INSERT INTO `vendedores`(`idVendedores`, `nombre`, `apellido`, `dni`) VALUES (NULL,'"+nombre+ "','" + apellido + "','" + dni + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return ("Carga Realizada con Éxito");

            }
            catch (Exception)
            {
                return ("");

            }

        }




        public string CargaProducto(string nombre, int precio, int cantidad, int idRubro)
        {
            string query = "INSERT INTO `productos`(`idProductos`, `nombre`, `precio`, `cantidad`, `idRubro`) VALUES (NULL,'"+nombre+ "'," + precio + "," + cantidad + "," + idRubro + ")";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return ("Carga Realizada con Éxito");

            }
            catch (Exception)
            {
                return ("");

            }

        }



        public string CargaRubro(string nombre)
        {
            string query = "INSERT INTO `rubro`(`idRubro`, `nombre`) VALUES (NULL,'"+ nombre +"')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return ("Carga Realizada con Éxito");

            }
            catch (Exception)
            {
                return ("");

            }

        }

        public string CargaProveedor(string nombre,string cuit)
        {
            string query = "INSERT INTO `proveedor`(`idProveedor`, `nombre`,`cuit`) VALUES (NULL,'" + nombre + "','" + cuit + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return ("Carga Realizada con Éxito");

            }
            catch (Exception)
            {
                return ("");

            }

        }

        public string CargaVentas(int idVentas,int cantidad, int montoTotal,int idVendedor,int idProducto)
        {
            string query = "INSERT INTO `ventas`(`idVentas`, `cantidad`, `montoTotal`, `idVendedor`, `idProducto`) VALUES(NULL,"+ cantidad +"," + montoTotal + "," + idVendedor + ","+idProducto+")";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            

            try
            {

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return ("Venta Realizada con Éxito");

            }
            catch (Exception)
            {
                return ("");

            }

        }


        public List<string> ConsultaProductos()
        {
            string query = "SELECT * FROM Productos";

            List<string> list = new List<string>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Clases.Productos Producto = new Clases.Productos();
                while(reader.Read())
                {
                    Producto.IdProducto = Convert.ToInt32(reader.GetValue(0));
                    Producto.Nombre = Convert.ToString(reader.GetValue(1));
                    Producto.Precio = Convert.ToInt32(reader.GetValue(2));
                    Producto.Cantidad = Convert.ToInt32(reader.GetValue(3));
                    Producto.Rubro = Convert.ToInt32(reader.GetValue(4));

                    list.Add(Producto.Nombre);


                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }


        public List<string> ConsultaRubroSpinner()
        {
            string query = "SELECT * FROM Rubro";

            List<string> list = new List<string>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Clases.Rubro Rubro = new Clases.Rubro();
                while (reader.Read())
                {
                    Rubro.IdRubro = Convert.ToInt32(reader.GetValue(0));
                    Rubro.Nombre = Convert.ToString(reader.GetValue(1));

                    list.Add(Rubro.Nombre);


                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<string> ConsultaVendedores2Spinner()
        {
            string query = "SELECT * FROM Vendedores";

            List<string> list = new List<string>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Clases.vendedores Vendedores = new Clases.vendedores();
                while (reader.Read())
                {
                    
                    Vendedores.Nombre = Convert.ToString(reader.GetValue(1));

                    list.Add(Vendedores.Nombre);


                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<string> ConsultaVendedoresSpinner()
        {
            string query = "SELECT * FROM Vendedores";

            List<string> list = new List<string>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Clases.vendedores vendedores = new Clases.vendedores();
                while (reader.Read())
                {
                    vendedores.IdVendedores = Convert.ToInt32(reader.GetValue(0));
                    vendedores.Nombre = Convert.ToString(reader.GetValue(1));
                    vendedores.Apellido = Convert.ToString(reader.GetValue(2));
                    vendedores.Dni = Convert.ToString(reader.GetValue(3));

                    list.Add(vendedores.Nombre);


                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Productos> ConsultaProductosCarga()
        {
            string query = "SELECT * FROM Productos";

            List<Clases.Productos> list = new List<Clases.Productos>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

               
                while (reader.Read())
                {
                    Clases.Productos Producto = new Clases.Productos();
                    Producto.IdProducto = Convert.ToInt32(reader.GetValue(0));
                    Producto.Nombre = Convert.ToString(reader.GetValue(1));
                    Producto.Precio = Convert.ToInt32(reader.GetValue(2));
                    Producto.Cantidad = Convert.ToInt32(reader.GetValue(3));
                    Producto.Rubro = Convert.ToInt32(reader.GetValue(4));

                    list.Add(Producto);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Rubro> ConsultaRubroCarga()
        {
            string query = "SELECT * FROM Rubro";

            List<Clases.Rubro> list = new List<Clases.Rubro>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

               
                while (reader.Read())
                {
                    Clases.Rubro Rubro = new Clases.Rubro();
                    Rubro.IdRubro = Convert.ToInt32(reader.GetValue(0));
                    Rubro.Nombre = Convert.ToString(reader.GetValue(1));

                    list.Add(Rubro);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.vendedores> ConsultaVendedoresCarga()
        {
            string query = "SELECT * FROM vendedores";

            List<Clases.vendedores> list = new List<Clases.vendedores>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.vendedores vendedor = new Clases.vendedores();
                    vendedor.IdVendedores= Convert.ToInt32(reader.GetValue(0));
                    vendedor.Nombre= Convert.ToString(reader.GetValue(1));
                    vendedor.Apellido = Convert.ToString(reader.GetValue(2));
                    vendedor.Dni= Convert.ToString(reader.GetValue(3));

                   

                    list.Add(vendedor);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }


        public List<Clases.proveedores> Consulta1()
        {
            string query = "SELECT Nombre,CUIT FROM Proveedores";

            List<Clases.proveedores> list = new List<Clases.proveedores>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.proveedores proveedores = new Clases.proveedores();
                    proveedores.IdProveedores = 0;
                    proveedores.Nombre = Convert.ToString(reader.GetValue(0));
                    proveedores.Cuit = Convert.ToString(reader.GetValue(1));
                 
                    list.Add(proveedores);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.vendedores> Consulta2()
        {
            string query = "SELECT Nombre,Apellido,DNI FROM Vendedores";

            List<Clases.vendedores> list = new List<Clases.vendedores>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.vendedores vendedores = new Clases.vendedores(); 
                    vendedores.Nombre = Convert.ToString(reader.GetValue(0));
                    vendedores.Apellido = Convert.ToString(reader.GetValue(1));
                    vendedores.Dni = Convert.ToString(reader.GetValue(2));
                  

                    list.Add(vendedores);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Productos> Consulta3()
        {
            string query = "SELECT Nombre, precio,cantidad FROM Productos";

            List<Clases.Productos> list = new List<Clases.Productos>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    productos.Nombre = Convert.ToString(reader.GetValue(0));
                    productos.Precio = Convert.ToInt32(reader.GetValue(1));
                    productos.Cantidad = Convert.ToInt32(reader.GetValue(2));


                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Productos> Consulta4()
        {
            string query = "SELECT Nombre, precio,cantidad FROM Productos WHERE cantidad = 0";

            List<Clases.Productos> list = new List<Clases.Productos>();

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    productos.Nombre = Convert.ToString(reader.GetValue(0));
                    productos.Precio = Convert.ToInt32(reader.GetValue(1));
                    productos.Cantidad = Convert.ToInt32(reader.GetValue(2));


                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Productos> Consulta5(ref List<Clases.proveedores> proveedores)
        {
            string query = "select  p.Nombre,prov.Nombre from Proveedores as prov,Productos as p,Compras as c where C.idProveedor =prov.idProveedores and c.idProductos=p.idProductos";

            List<Clases.Productos> list = new List<Clases.Productos>();
            
           

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    Clases.proveedores proveedor = new Clases.proveedores();
                    productos.Nombre = Convert.ToString(reader.GetValue(0));
                    proveedor.Nombre = Convert.ToString(reader.GetValue(1));


                    proveedores.Add(proveedor);
                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }


        public List<Clases.Productos> Consulta6(ref List<Clases.vendedores> vendedores, ref List<Clases.ventas> ventas)
        {
            string query = "SELECT Vendedores.Nombre, Vendedores.Apellido, p.Nombre, v.Cantidad, v.MontoTotal FROM Vendedores, productos as p, ventas as v WHERE v.idVendedor=vendedores.idVendedores and v.idProducto= p.idProductos";

            List<Clases.Productos> list = new List<Clases.Productos>();



            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    Clases.vendedores vendedor = new Clases.vendedores();
                    Clases.ventas venta = new Clases.ventas();
                    vendedor.Nombre = Convert.ToString(reader.GetValue(0));
                    vendedor.Apellido = Convert.ToString(reader.GetValue(1));
                    productos.Nombre = Convert.ToString(reader.GetValue(2));
                    venta.Cantidad = Convert.ToInt32(reader.GetValue(3));
                    venta.MontoTotal = Convert.ToInt32(reader.GetValue(4));

                    ventas.Add(venta);
                    vendedores.Add(vendedor);
                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }

        public List<Clases.Productos> Consulta7(ref List<Clases.vendedores> vendedores, ref List<Clases.ventas> ventas,string nombre)
        {
            string query = "SELECT Vendedores.Nombre, Vendedores.Apellido, p.Nombre, v.Cantidad, v.MontoTotal FROM Vendedores, productos as p, ventas as v WHERE vendedores.nombre='"+nombre+"' and vendedores.idVendedores=v.idVendedor and v.idProducto=p.idProductos";

            List<Clases.Productos> list = new List<Clases.Productos>();



            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    Clases.vendedores vendedor = new Clases.vendedores();
                    Clases.ventas venta = new Clases.ventas();
                    vendedor.Nombre = Convert.ToString(reader.GetValue(0));
                    vendedor.Apellido = Convert.ToString(reader.GetValue(1));
                    productos.Nombre = Convert.ToString(reader.GetValue(2));
                    venta.Cantidad = Convert.ToInt32(reader.GetValue(3));
                    venta.MontoTotal = Convert.ToInt32(reader.GetValue(4));

                    ventas.Add(venta);
                    vendedores.Add(vendedor);
                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }
        public List<Clases.proveedores> Consulta8(ref List<Clases.Rubro> rubros)
        {
            string query = "SELECT DISTINCT prov.nombre, r.nombre FROM proveedores as prov , productos as p , rubro as r, compras as c WHERE prov.idProveedores = c.idProveedor AND c.idProductos = p.idProductos and p.idRubro = r.idRubro";

            List<Clases.proveedores> list = new List<Clases.proveedores>();



            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.proveedores prov = new Clases.proveedores();
                    Clases.Rubro rubro = new Clases.Rubro();
                    prov.Nombre = Convert.ToString(reader.GetValue(0));
                    rubro.Nombre = Convert.ToString(reader.GetValue(1));
                    
                    
                    rubros.Add(rubro);
                    list.Add(prov);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }
        public List<Clases.Rubro> Consulta9(ref List<Clases.vendedores> vendedores)
        {
            string query = "SELECT DISTINCT vendedores.nombre as Vendedor, r.nombre AS Rubro FROM vendedores, ventas AS v, productos as p , rubro AS r where NOT(vendedores.idVendedores = v.idVendedor AND v.idProducto = p.idProductos and p.idRubro = r.idRubro) ORDER BY vendedores.nombre ASC";

            List<Clases.Rubro> list = new List<Clases.Rubro>();



            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.vendedores vend = new Clases.vendedores();
                    Clases.Rubro rubro = new Clases.Rubro();
                    vend.Nombre = Convert.ToString(reader.GetValue(0));
                    rubro.Nombre = Convert.ToString(reader.GetValue(1));


                    vendedores.Add(vend);
                    list.Add(rubro);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }
        public List<Clases.Productos> Consulta10(string nombre)
        {
            string query = "select nombre,cantidad,precio from Productos where not exists(select* from Rubro where not exists(select* from Productos as PX where(PX.nombre like '%"+nombre+"%' and Productos.nombre like '%"+nombre+ "%') and PX.idRubro = Rubro.idRubro)) and nombre like '%" + nombre + "%'";

            List<Clases.Productos> list = new List<Clases.Productos>();



            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.Productos productos = new Clases.Productos();
                    productos.Nombre = Convert.ToString(reader.GetValue(0));
                    productos.Cantidad = Convert.ToInt32(reader.GetValue(1));
                    productos.Precio = Convert.ToInt32(reader.GetValue(2));


                    list.Add(productos);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }
        public List<Clases.proveedores> Consulta11()
        {
            string query = "select nombre from Proveedores as P where not exists(select* from Compras as C,Productos where not exists(select* from Proveedores as PX,Compras as CX where(PX.idProveedores = P.idProveedores and PX.idProveedores = CX.idProveedor  and CX.idProductos = Productos.idProductos))and C.idProductos = Productos.idProductos)";

            List<Clases.proveedores> list = new List<Clases.proveedores>();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read())
                {
                    Clases.proveedores prov = new Clases.proveedores();
                    prov.Nombre = Convert.ToString(reader.GetValue(0));
                    list.Add(prov);

                }



                databaseConnection.Close();
                return list;
            }
            catch (Exception)
            {

                return list;
            }
        }
    }
}