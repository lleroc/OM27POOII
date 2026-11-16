namespace Floricola.Controladores
{
    using Floricola.Modelos;
    using System.IO;
    using System.Linq;

    public class EstadoCivilController
    {
        public List<EstadoCivilModel> listaEstadoCivil = new List<EstadoCivilModel>();

        string archivo = Path.Combine(AppContext.BaseDirectory,
            "Recursos","txt", "EstadoCivil.txt");

        public EstadoCivilController()
        {
            if (File.Exists(archivo)){
                foreach (var linea in File.ReadAllLines(archivo)) {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 2 && int.TryParse(datos[0], out int id)) {
                        listaEstadoCivil.Add(new EstadoCivilModel { 
                            Id = id, 
                            Descripcion = datos[1] 
                        });
                    }
                }
            }
            
        }// 1, Casado
        public EstadoCivilModel NuevoEstadoCivil(string Detalle) { 
            EstadoCivilModel estadoCivil = new EstadoCivilModel
            { 
                Descripcion = Detalle,
                Id = IdEstadoCivil()
            };

            //estadoCivil.Descripcion = Detalle;
            //estadoCivil.Id = IdEstadoCivil();
            
            Directory.CreateDirectory(Path.GetDirectoryName(archivo));

            File.WriteAllLines(archivo,listaEstadoCivil.
                Select(ec => $"{ec.Id},{ec.Descripcion}"));

            listaEstadoCivil.Add(estadoCivil);
            return estadoCivil;
        }

        public List<EstadoCivilModel> ListarEstadoCivil()
        {
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

        public int IdEstadoCivil()
        {
            return listaEstadoCivil.Count + 1;

        }
    }
}
