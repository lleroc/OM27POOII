using Floricola.Controladores;

namespace Floricola.Vistas.EstadoCivil
{
    public partial class FrmNuevoEstadoCivil : Form
    {
        public static readonly FrmListaEstadoCivil frmListaEstadoCivil = new FrmListaEstadoCivil();
        public FrmNuevoEstadoCivil()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmListaEstadoCivil.estadoCivil.NuevoEstadoCivil(txtNuevo.Text);
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
