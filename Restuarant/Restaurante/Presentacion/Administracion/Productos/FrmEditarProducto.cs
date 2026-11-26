using Restaurante.Negocio;
using Restaurante.Datos.Entidades;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmEditarProducto : Form
    {
        int _id = 0;
        private readonly ProductosService _productosService = new ProductosService();
        public FrmEditarProducto(int id)
        {
            InitializeComponent();
            _id = id;
        }

        async private void btnGuardar_Click(object sender, EventArgs e)
        {
            var prodcuto = new Producto
            {
                Id = _id,
                Nombre = txtNombre.Text.Trim(),
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value

            };
            try
            {
                if (await _productosService.editar(prodcuto))
                {
                    MessageBox.Show("Se guardo con exito");
                    this.DialogResult = DialogResult.OK;
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

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            var produto = _productosService.uno(_id);
            txtNombre.Text = produto.Nombre;
            nudPVP.Value = produto.PVP;
            nudPC.Value = produto.Costo_Fabricacion;
        }
    }
}
