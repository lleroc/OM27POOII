using System;
using System.Collections.Generic;
using System.Text;
using Floricola.Modelos;
using Floricola.BaseDatos;
using MySql.Data.MySqlClient;
using Floricola.Modelos.ViewModel;
namespace Floricola.Controladores
{
    public class EmpleadoController
    {
        private readonly ConexionMySql _mysql = new ConexionMySql();
        private readonly UsuariosController _usuariosController = new UsuariosController();

        public EmpleadoModel nuevo(EmpleadoModel empleado, UsuarioModel usuario) {
            using (MySqlConnection cn = _mysql.ObtenerConexion())
            {
                cn.Open();
                StringBuilder cadena = new StringBuilder();
                cadena.Append("INSERT INTO empleados");
                cadena.Append("(cedula, nombres, apellidos, direccion, " +
                    "telefono, celular, correo, estado_civil_id)");
                cadena.Append("VALUES");
                cadena.Append("(@cedula, @nombres, @apellidos, @direccion, @" +
                    "telefono, @celular, @correo, @estado_civil_id)");
                using (MySqlCommand cmd = new MySqlCommand(cadena.ToString(), cn)) { 
                    cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("@nombres", empleado.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                    cmd.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@celular", empleado.Celular);
                    cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@estado_civil_id", empleado.EstadoCivilModelId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        empleado.Id = (int)cmd.LastInsertedId;

                        if (empleado.Id > 0)
                        {
                            usuario.empleado_id = empleado.Id;
                            if (_usuariosController.CrearUsuario(usuario))
                            {
                                return empleado;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
        }

        public EmpleadoModel editar(EmpleadoModel empleado, UsuarioModel usuario)
        {
            using (MySqlConnection cn = _mysql.ObtenerConexion())
            {
                cn.Open();
                StringBuilder cadena = new StringBuilder();
                cadena.Append("UPDATE empleados SET ");
                cadena.Append("cedula = @cedula, nombres = @nombres, " +
                    "apellidos = @apellidos, direccion = @direccion, ");
                cadena.Append("telefono = @telefono, celular = @celular, " +
                    "correo = @correo, estado_civil_id = @estado_civil_id ");
                cadena.Append("WHERE id = @id");
                using (MySqlCommand cmd = new MySqlCommand(cadena.ToString(), cn))
                {
                    cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("@nombres", empleado.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                    cmd.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@celular", empleado.Celular);
                    cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@estado_civil_id", empleado.EstadoCivilModelId);
                    cmd.Parameters.AddWithValue("@id", empleado.Id);
                

                    try
                    {
                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            usuario.empleado_id = empleado.Id;
                            if (_usuariosController.ActualizarUsuario(usuario))
                            {
                                return empleado;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
        }

        public List<EmpleadoModel> todos() {
            List<EmpleadoModel> lista = new List<EmpleadoModel>();
            using (MySqlConnection cn = _mysql.ObtenerConexion())
            {
                cn.Open();
                string cadena = "SELECT concat(nombres,' ', apellidos) as nombre_completo " +
                    ", id FROM empleados";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn)) {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var empleado = new EmpleadoModel
                            {
                                Id = lector.GetInt32("id"),
                                Nombres = lector.GetString("nombre_completo")
                            };
                            lista.Add(empleado);
                        }
                    }
                }
            }
            return lista;

        }

        public UEmpleadoViewModel uno(int id) {
            using (MySqlConnection cn = _mysql.ObtenerConexion())
            {
                cn.Open();
                string cadena = $"SELECT e.id as empleadoId, e.cedula, e.nombres ," +
                   $" e.apellidos, e.direccion , e.telefono , e.celular , e.correo, " +
                   $" e.estado_civil_id, ec.descripcion, u.nombre_usuario, " +
                   $"u.password_hash , u.activo, u.id as usaurioid FROM empleados e " +
                   $"INNER JOIN estados_civiles ec ON e.estado_civil_id = ec.id " +
                   $"INNER JOIN usuarios u ON e.id = u.empleado_id where e.id = @id; ";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        return new UEmpleadoViewModel
                        {
                            Id = lector.GetInt32("empleadoId"),
                            Nombres = lector.GetString("nombres"),
                            Apellidos = lector.GetString("apellidos"),
                            Cedula = lector.GetString("cedula"),
                            Celular = lector.GetString("celular"),
                            Correo = lector.GetString("correo"),
                            EstadoCivilModelId = lector.GetInt32("estado_civil_id"),
                            DescripcionEstadoCivil = lector.GetString("descripcion"),
                            Direccion = lector.GetString("direccion"),
                            Telefono = lector.GetString("telefono"),
                            UsuarioId = lector.GetInt32("usaurioid"),
                            Nombre_Usuario = lector.GetString("nombre_usuario"),
                            Password = lector.GetString("password_hash"),
                            Activo = lector.GetBoolean("activo")
                        };
                    }
                    else { 
                        return null;
                    }
                }

            }
        }
    
        public bool eliminar(int idEmpleado)
        {
            using (MySqlConnection cn = _mysql.ObtenerConexion())
            {
                cn.Open();

                var usuarioEliminado = _usuariosController.EliminarUsuarioEmpleado(idEmpleado);
                if (!usuarioEliminado)
                {
                    return false; // No se pudo eliminar el usuario, por lo que no se elimina el empleado
                }

                string cadena = "DELETE FROM empleados WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
