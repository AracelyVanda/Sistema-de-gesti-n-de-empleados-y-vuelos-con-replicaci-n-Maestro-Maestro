using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_proyecto_2026
{
    internal class VueloDAO
    {
        private ConexionBD conexionDB = new ConexionBD();

        // INSERT
        public bool Insertar(VueloDTO vuelo)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "INSERT INTO vuelo(idVuelo, origen, destino, noAsientos, precio, fechaInicio, fechaLlegada, estatus) " +
                    "VALUES(@idVuelo, @origen, @destino, @noAsientos, @precio, @fechaInicio, @fechaLlegada, @estatus)";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idVuelo", vuelo.IdVuelo);
                cmd.Parameters.AddWithValue("@origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@noAsientos", vuelo.NoAsientos);
                cmd.Parameters.AddWithValue("@precio", vuelo.Precio);
                cmd.Parameters.AddWithValue("@fechaInicio", vuelo.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaLlegada", vuelo.FechaLlegada);
                cmd.Parameters.AddWithValue("@estatus", vuelo.Estatus);
                



                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SELECT
        public List<VueloDTO> ObtenerTodos()
        {
            List<VueloDTO> lista = new List<VueloDTO>();

            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "SELECT * FROM vuelo";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VueloDTO u = new VueloDTO
                    {
                        IdVuelo = reader.GetInt32("idVuelo"),
                        Origen = reader.GetString("origen"),
                        Destino = reader.GetString("destino"),
                        NoAsientos = reader.GetInt16("noAsientos"),
                        Precio = reader.GetDouble("precio"),
                        FechaInicio = reader.GetDateTime("fechaInicio"),
                        FechaLlegada = reader.GetDateTime("fechaLlegada"),
                        Estatus = reader.GetByte("estatus"),
                        

                    };

                    lista.Add(u);
                }
            }

            return lista;
        }

        // UPDATE
        public bool Actualizar(VueloDTO vuelo)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = @"UPDATE vuelo
                               SET origen=@origen,
                               destino=@destino,
                               noAsientos=@noAsientos,
                               precio=@precio,
                               fechaInicio=@fechaInicio,
                               fechaLlegada=@fechaLlegada,
                               estatus=@estatus
                               
                               WHERE idVuelo=@idVuelo";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@idVuelo", vuelo.IdVuelo);
                cmd.Parameters.AddWithValue("@origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@noAsientos", vuelo.NoAsientos);
                cmd.Parameters.AddWithValue("@precio", vuelo.Precio);
                cmd.Parameters.AddWithValue("@fechaInicio", vuelo.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaLlegada", vuelo.FechaLlegada);
                cmd.Parameters.AddWithValue("@estatus", vuelo.Estatus);
                


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // DELETE
        public bool Eliminar(int id)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "DELETE FROM vuelo WHERE idVuelo=@idVuelo";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idVuelo", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        //Auditoria
        public DataTable MostrarAuditorias()
        {
            DataTable dt = new DataTable();



            string sql = "SELECT * FROM audi_vuelo";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexionDB.ObtenerConexion());
            da.Fill(dt);



            return dt;
        }


        //Buscar desde la tabla de vuelo solamente
        public DataTable BuscarVuelo(string texto)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string consulta = @"SELECT *
                    FROM vuelo
                    WHERE CAST(idVuelo AS CHAR) LIKE @texto
                    OR origen LIKE @texto
                    OR destino LIKE @texto
                    OR CAST(noAsientos AS CHAR) LIKE @texto
                    OR CAST(precio AS CHAR) LIKE @texto
                    OR CAST(fechaInicio AS CHAR) LIKE @texto
                    OR CAST(fechaLlegada AS CHAR) LIKE @texto
                    OR CAST(estatus AS CHAR) LIKE @texto";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        //Buscar desde la tabla de auditorias
        public DataTable BuscarAuditorias(string texto)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string consulta = @"SELECT *
                    FROM audi_vuelo
                    WHERE CAST(id AS CHAR) LIKE @texto
                    OR origenAnt LIKE @texto
                    OR destinoAnt LIKE @texto
                    OR CAST(noAsientosAnt AS CHAR) LIKE @texto
                    OR CAST(precioAnt AS CHAR) LIKE @texto
                    OR CAST(fechaInicioAnt AS CHAR) LIKE @texto
                    OR CAST(fechaLlegadaAnt AS CHAR) LIKE @texto
                    OR CAST(estatusAnt AS CHAR) LIKE @texto
                    OR origenNue LIKE @texto
                    OR destinoNue LIKE @texto
                    OR CAST(noAsientosNue AS CHAR) LIKE @texto
                    OR CAST(precioNue AS CHAR) LIKE @texto
                    OR CAST(fechaInicioNue AS CHAR) LIKE @texto
                    OR CAST(fechaLlegadaNue AS CHAR) LIKE @texto
                    OR CAST(estatusNue AS CHAR) LIKE @texto
                    OR usuario LIKE @texto
                    OR CAST(modificado AS CHAR) LIKE @texto
                    OR accion LIKE @texto
                    OR CAST(idVuelo AS CHAR) LIKE @texto";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
