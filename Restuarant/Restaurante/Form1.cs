using Restaurante.Presentacion.Administracion.Productos;
using System.Runtime.CompilerServices;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmProductos = new FrmListaProductos();
            frmProductos.Show();
            this.Hide();
        }
    }
}
