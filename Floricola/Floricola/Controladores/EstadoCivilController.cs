namespace Floricola.Controladores
{
    using Floricola.BaseDatos;
    using Floricola.Modelos;
    using MySql.Data.MySqlClient;
    using System.IO;
    using System.Linq;

    public class EstadoCivilController
    {
        public List<EstadoCivilModel> listaEstadoCivil = new List<EstadoCivilModel>();
        public ConexionMySql _mysql = new ConexionMySql();



        public EstadoCivilController()
        {
            //if (File.Exists(archivo)){
            //    foreach (var linea in File.ReadAllLines(archivo)) {
            //        string[] datos = linea.Split(',');
            //        if (datos.Length == 2 && int.TryParse(datos[0], out int id)) {
            //            listaEstadoCivil.Add(new EstadoCivilModel { 
            //                Id = id, 
            //                Descripcion = datos[1] 
            //            });
            //        }
            //    }
            //}
            
        }// 1, Casado
        public void NuevoEstadoCivil(string Detalle) { 
           
        }

        public List<EstadoCivilModel> ListarEstadoCivil()
        {
            using (MySqlConnection cn = _mysql.ObtenerConexion()) { 
                
                cn.Open();
                string cadena = "select * from estados_civiles";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn)) { 

                    var lector = cmd.ExecuteReader();

                    while (lector.Read())
                    {
                        var estadoCivil = new EstadoCivilModel
                        {
                            Id = lector.GetInt32("id"),
                            Descripcion = lector.GetString("descripcion")
                        };
                        listaEstadoCivil.Add(estadoCivil);
                    }

                }

            }
            return listaEstadoCivil;
        }

        public EstadoCivilModel EditarEstadoCivil(EstadoCivilModel estadoCivil)
        {
            var estado = listaEstadoCivil.FirstOrDefault(ec => ec.Id == estadoCivil.Id);
            try
            {
                estado.Descripcion = estadoCivil.Descripcion;
                return estado;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al editar el estado civil: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new EstadoCivilModel { Id = 0, Descripcion= ex.Message };
            }
            
        }

        public bool EliminarEstadoCivil(EstadoCivilModel estado)
        {
            var estadoCivil = listaEstadoCivil.FirstOrDefault(e => e.Id == estado.Id);
            if (estadoCivil != null)
            {
                listaEstadoCivil.Remove(estadoCivil);
                return true;
            }
            return false;
        }

        //public int IdEstadoCivil()
        //{
        //    return listaEstadoCivil.Count + 1;

        //}
    }
}
