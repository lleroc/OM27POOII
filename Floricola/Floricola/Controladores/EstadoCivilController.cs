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
            estadoCivil.ListarEstadoCivil().Add(estadoCivil);
            return estadoCivil;
        }

        public List<EstadoCivilModel> ListarEstadoCivil()
        {
            return listaEstadoCivil;
        }

        public EstadoCivilModel EditarEstadoCivil(int Id, string Detalle)
        {
            var estadoCivil = listaEstadoCivil.FirstOrDefault(e => e.Id == Id);
            if (estadoCivil != null)
            {
                estadoCivil.Descripcion = Detalle;
            }
            return estadoCivil;
        }

        public bool EliminarEstadoCivil(int Id)
        {
            var estadoCivil = listaEstadoCivil.FirstOrDefault(e => e.Id == Id);
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
