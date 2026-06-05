using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
using MySqlConnector;
namespace bd_proyecto_2026
{
    internal class ConexionBD
    {
        //string cadenaConexion = "Server=localhost;Port=3306;Database=aero;Uid=root;Pwd=206040;"; 
        //string cadenaConexion = "Server=localhost;Port=3306;Database=aero;Uid=liam;Pwd=123;";         //Para que el usuario de liam
        string cadenaConexion = "Server=localhost;Port=3306;Database=aero;Uid=aracely;Pwd=123;";        //Para entrar con el usuario de aracely
        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return conexion;

        }
    }

}
