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
    public partial class FrmNuevoProducto : Form
    {
        private readonly ProductosService _productosService = new ProductosService();
        private readonly CategoriasServicio _categoriaService = new CategoriasServicio();
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var prodcuto = new Producto
            {
                Nombre = textBox1.Text.Trim(),
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value,
                CategoriasId = (int)cmbCategoria.SelectedValue
            };
            try
            {
                if (_productosService.insertar(prodcuto))
                {
                    MessageBox.Show("Se guardo con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ocurrio un error al gurdar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error al gurdar");
            }

        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = _categoriaService.todos();
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "Detalle";



        }
    }
}
