using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasDeDatos
{
    public class ConexionDB
    {
        public ConexionDB()
        {
           
        }

        public string test (string xquery)
        {
            // La siguiente linea es la que provee la conexión entre C# y MySQL.
            // Debes cambiar el nombre de usuario, contrasenia y nombre de base de datos
            // de acuerdo a tus datos
            // Puedes ignorar la opción de base de datos (database) si quieres acceder a todas
            // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Tu consulta en SQL
            string query = xquery;

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            
            // A consultar !
            try
            {
                // Abre la base de datos
                databaseConnection.Open();

                databaseConnection.Close();
                return ("Conexión establecida con éxito");
               
            }
            catch (Exception ex)
            {
                return ("Conexión NO establecida");
              
            }

        }


        public List<Clases.Productos> consultaProductos(string xquery)
        {

            List<Clases.Productos> lista = new List<Clases.Productos>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Seleccionar todo
            string query = xquery;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Clases.Productos Producto = new Clases.Productos();
                while (reader.Read()) //Linea sea null
                {
                    
                    Producto.IdProducto = reader.GetInt32(0);
                    Producto.Nombre = Convert.ToString(reader.GetString(1));
                    Producto.Precio = Convert.ToInt32(reader.GetInt32(2));
                    Producto.Cantidad = Convert.ToInt32(reader.GetInt32(3));
                    Producto.Rubro = Convert.ToInt32(reader.GetInt32(4)); 
                  //  lista.Add(Convert.ToString(reader.GetString(1)) + " " + Convert.ToString(reader.GetString(2)) + " " + "/");
                    lista.Add(Producto);
                }

                databaseConnection.Close();

                return lista;
            }

            catch (Exception ex)
            {
               
                return lista;

            }
        }































        public List<string> consulta1(string xquery)
        {

            List<string> lista = new List<string>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Seleccionar todo
            string query = xquery;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();


                while(reader.Read()) //Linea sea null
                {
                    lista.Add(Convert.ToString(reader.GetString(1))+" "+ Convert.ToString(reader.GetString(2)) + " "+"/");
                }
                    databaseConnection.Close();

                    return lista;
                }
               
                catch (Exception ex)
                {
                     lista.Add("VACÍO");
                       return lista ;
               
                 }
            }

        public List<string> consulta589(string xquery)
        {

            List<string> lista = new List<string>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Seleccionar todo
            string query = xquery;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read()) //Linea sea null
                {

                    lista.Add(Convert.ToString(reader.GetString(0)) + " " + Convert.ToString(reader.GetString(1)) + " " + "/");
                }
                databaseConnection.Close();

                return lista;
            }

            catch (Exception ex)
            {
                lista.Add("VACÍO");
                return lista;

            }
        }

        public List<string> consulta67(string xquery)
        {

            List<string> lista = new List<string>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Seleccionar todo
            string query = xquery;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read()) //Linea sea null
                {

                    lista.Add(Convert.ToString(reader.GetString(0)) + " " + Convert.ToString(reader.GetString(1)) + " " + Convert.ToString(reader.GetString(2)) + " " + Convert.ToString(reader.GetString(3)) + " " + Convert.ToString(reader.GetString(4)) + " " + "/");
                }
                databaseConnection.Close();

                return lista;
            }

            catch (Exception ex)
            {
                lista.Add("VACÍO");
                return lista;

            }
        }

        public List<string> consulta234(string xquery)
        {

            List<string> lista = new List<string>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            // Seleccionar todo
            string query = xquery;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();


                while (reader.Read()) //Linea sea null
                {

                    lista.Add(Convert.ToString(reader.GetString(0)) + " " + Convert.ToString(reader.GetString(1)) + " " +Convert.ToString(reader.GetString(2)) + " " + " /" );
                }
                databaseConnection.Close();

                return lista;
            }

            catch (Exception ex)
            {
                lista.Add("VACÍO");
                return lista;

            }
        }




        public string Insertar(string xquery)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ferreteria;";
            string query = xquery;
          
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

            

                databaseConnection.Close();
                return ("Se cargó exitosamente");
            }
            catch (Exception ex)
            {
                return ("Error en la carga"); 
            }
        }


    }
}