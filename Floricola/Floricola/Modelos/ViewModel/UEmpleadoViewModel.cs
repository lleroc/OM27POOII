namespace Floricola.Modelos.ViewModel
{
    public class UEmpleadoViewModel
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int EstadoCivilModelId { get; set; }
        public string DescripcionEstadoCivil { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
    }
}
