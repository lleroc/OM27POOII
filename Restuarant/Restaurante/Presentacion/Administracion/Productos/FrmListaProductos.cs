using Restaurante.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Restaurante.Datos.Entidades;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmListaProductos : Form
    {

        private readonly ProductosService _productos = new ProductosService();
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            cargalista();
        }

        public void cargalista()
        {
            lstListaproductos.DataSource = null;
            lstListaproductos.Items.Clear();

            lstListaproductos.DataSource = new BindingList<Producto>(_productos.todos());
            lstListaproductos.ValueMember = "id";
            lstListaproductos.DisplayMember = "nombre";
            lstListaproductos.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var frmNuevo = new FrmNuevoProducto();
            frmNuevo.ShowDialog();
            cargalista();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstListaproductos.SelectedIndex == -1) return;
            var frmEditar = new FrmEditarProducto((int)lstListaproductos.SelectedValue);
            frmEditar.ShowDialog();
            cargalista();
        }

        private void FrmListaProductos_Activated(object sender, EventArgs e)
        {
            cargalista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult mensaje =
                MessageBox.Show("Eliminar Producto", "Desea eliminar el producto",
                MessageBoxButtons.YesNo);

            if (mensaje == DialogResult.Yes)
            {
                if (_productos.eliminar((int)lstListaproductos.SelectedValue))
                {
                    MessageBox.Show("Productos", "Se elimino con exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Productos", "No se elimino el producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Productos", "El usuario cancelo el borrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
