namespace Floricola.Modelos
{
    public class UsuarioModel : EmpleadoModel
    {
        public int id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public int empleado_id { get; set; }

    }
}
