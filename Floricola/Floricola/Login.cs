namespace Floricola
{
    using Floricola.Controladores;
    using Floricola.Modelos;

    public partial class Login : Form
    {
        private readonly UsuariosController _usuariosController;
        public Login()
        {
            InitializeComponent();
            _usuariosController = new UsuariosController();

        }
        public async void button3_Click(object sender, EventArgs e)
        {

            string nombreUsuario = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
               lblMensaje.Text = "Por favor, ingrese un \n nombre de usuario \n y una  contraseña.";
                return;
            }

            try
            {
                var usuarioValidado = _usuariosController.InciarSesion(nombreUsuario, password);
                if (usuarioValidado == null)
                {
                    lblMensaje.Text = "Usuario o contraseña \n incorrectos.";
                    return;
                }
                lblMensaje.Text = "Bienvenido, " + usuarioValidado.Nombre_Usuario;

                //await Task.Delay(3000); // Espera 3 segundos antes de abrir el dashboard

                var dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();

            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public async void grabar() { 
            var usuario = new UsuarioModel
            {
                Nombre_Usuario = "admin",
                Password = "admin123",
                Activo = true
            };
            
            if (_usuariosController.CrearUsuario(usuario))
            {
                lblMensaje.Text = "Usuario creado correctamente.";
            }
            else
            {
                lblMensaje.Text = "Error al crear el usuario.";
            }
        }


    }

    
}
