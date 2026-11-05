namespace Floricola.Controladores
{
    using Floricola.Modelos;
    public class EstadoCivilController
    {
        public List<EstadoCivilModel> listaEstadoCivil = new List<EstadoCivilModel>();

        public EstadoCivilController()
        {
            
        }
        public EstadoCivilModel NuevoEstadoCivil(string Detalle) { 
            EstadoCivilModel estadoCivil = new EstadoCivilModel
            { 
                Descripcion = Detalle,
                Id = IdEstadoCivil()
            };

            //estadoCivil.Descripcion = Detalle;
            //estadoCivil.Id = IdEstadoCivil();
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
