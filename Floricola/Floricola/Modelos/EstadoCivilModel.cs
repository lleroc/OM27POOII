namespace Floricola.Modelos
{
    public class EstadoCivilModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<EstadoCivilModel> ListarEstadoCivil()
        {
            return new List<EstadoCivilModel>();
        }
    }
}
