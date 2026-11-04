namespace Floricola.Modelos
{
    public class UsuarioModel : EmpleadoModel
    {
        public string Nombre_Usuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
      
    }
}
