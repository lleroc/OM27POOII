using System;
using System.Collections.Generic;
using System.Text;
using Floricola.Modelos;
using Floricola.BaseDatos;
using MySql.Data.MySqlClient;
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
                            usuario.EstadoCivilModelId = empleado.Id;
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
    }
}
