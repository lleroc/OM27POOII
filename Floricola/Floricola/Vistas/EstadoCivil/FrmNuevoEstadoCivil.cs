using Floricola.Controladores;
using Floricola.Modelos;
namespace Floricola.Vistas.EstadoCivil
{
    public partial class FrmNuevoEstadoCivil : Form
    {
        private readonly EstadoCivilController _estadoCivilController;
        public FrmNuevoEstadoCivil(EstadoCivilController estadoCivilController)
        {
            InitializeComponent();
            _estadoCivilController = estadoCivilController;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                _estadoCivilController.NuevoEstadoCivil(txtNuevo.Text.Trim());
                MessageBox.Show("Estado Civil agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Estado Civil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
