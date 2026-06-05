using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace bd_proyecto_2026
{
    
    internal class EmpleadoDAO
    {
        private ConexionBD conexionDB = new ConexionBD();

        // INSERT
        public bool Insertar(EmpleadoDTO empleado)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "INSERT INTO empleado(idEmpleado, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo, rfc, telefono, estatus, sueldo, area) " +
                    "VALUES(@idEmpleado, @nombre, @apellidoPAterno, @apellidoMaterno, @fechaNacimiento, @sexo, @rfc, @telefono, @estatus, @sueldo, @area)";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@fechaNAcimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", empleado.Sexo);
                cmd.Parameters.AddWithValue("@rfc", empleado.Rfc);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@estatus", empleado.Estatus);
                cmd.Parameters.AddWithValue("@sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@area", empleado.Area);
               


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SELECT
        public List<EmpleadoDTO> ObtenerTodos()
        {
            List<EmpleadoDTO> lista = new List<EmpleadoDTO>();

            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "SELECT * FROM empleado";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmpleadoDTO u = new EmpleadoDTO
                    {
                        IdEmpleado = reader.GetInt32("idEmpleado"),
                        Nombre = reader.GetString("nombre"),
                        ApellidoPaterno = reader.GetString("apellidoPaterno"),
                        ApellidoMaterno = reader.GetString("apellidoMaterno"),
                        FechaNacimiento = reader.GetDateTime("fechaNacimiento"),
                        Sexo = reader.GetChar("sexo"),
                        Rfc = reader.GetString("rfc"),
                        Telefono = reader.GetString("telefono"),
                        Estatus = reader.GetByte("estatus"),
                        Sueldo = reader.GetDouble("sueldo"),
                        Area = reader.GetString("area"),

                    };

                    lista.Add(u);
                }
            }

            return lista;
        }

        // UPDATE
        public bool Actualizar(EmpleadoDTO empleado)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = @"UPDATE empleado
                               SET nombre=@nombre,
                               apellidoPaterno=@apellidoPaterno,
                               apellidoMaterno=@apellidoMaterno,
                               fechaNacimiento=@fechaNacimiento,
                               sexo=@sexo,
                               rfc=@rfc,
                               telefono=@telefono,
                               estatus=@estatus,
                               sueldo=@sueldo,
                               area=@area
                               WHERE idEmpleado=@idEmpleado";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@fechaNAcimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", empleado.Sexo);
                cmd.Parameters.AddWithValue("@rfc", empleado.Rfc);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@estatus", empleado.Estatus);
                cmd.Parameters.AddWithValue("@sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@area", empleado.Area);


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // DELETE
        public bool Eliminar(int id)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string sql = "DELETE FROM empleado WHERE idEmpleado=@idEmpleado";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idEmpleado", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        //Auditoria
        public DataTable MostrarAuditorias()
        {
            DataTable dt = new DataTable();

             

            string sql = "SELECT * FROM audi_empleado";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexionDB.ObtenerConexion());
            da.Fill(dt);

            

            return dt;
        }

        //Buscar desde la tabla de empleado solamente
        public DataTable BuscarEmpleado(string texto)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string consulta = @"SELECT *
                    FROM empleado
                    WHERE CAST(idEmpleado AS CHAR) LIKE @texto
                    OR nombre LIKE @texto
                    OR apellidoPaterno LIKE @texto
                    OR apellidoMaterno LIKE @texto
                    OR CAST(fechaNacimiento AS CHAR) LIKE @texto
                    OR sexo LIKE @texto
                    OR rfc LIKE @texto
                    OR telefono LIKE @texto
                    OR CAST(estatus AS CHAR) LIKE @texto
                    OR CAST(sueldo AS CHAR) LIKE @texto
                    OR area LIKE @texto";

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
                    FROM audi_empleado
                    WHERE CAST(id AS CHAR) LIKE @texto
                    OR nombreAnt LIKE @texto
                    OR apellidoPaternoAnt LIKE @texto
                    OR apellidoMaternoAnt LIKE @texto
                    OR CAST(fechaNacimientoAnt AS CHAR) LIKE @texto
                    OR sexoAnt LIKE @texto
                    OR rfcAnt LIKE @texto
                    OR telefonoAnt LIKE @texto
                    OR CAST(estatusAnt AS CHAR) LIKE @texto
                    OR CAST(sueldoAnt AS CHAR) LIKE @texto
                    OR areaAnt LIKE @texto
                    OR nombreNue LIKE @texto
                    OR apellidoPaternoNue LIKE @texto
                    OR apellidoMaternoNue LIKE @texto
                    OR CAST(fechaNacimientoNue AS CHAR) LIKE @texto
                    OR sexoNue LIKE @texto
                    OR rfcNue LIKE @texto
                    OR telefonoNue LIKE @texto
                    OR CAST(estatusNue AS CHAR) LIKE @texto
                    OR CAST(sueldoNue AS CHAR) LIKE @texto
                    OR areaNue LIKE @texto
                    OR usuario LIKE @texto
                    OR CAST(modificado AS CHAR) LIKE @texto
                    OR accion LIKE @texto
                    OR CAST(idEmpleado AS CHAR) LIKE @texto";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    } 
}
