using Floricola.Recursos;
using Floricola.Vistas.EstadoCivil;

namespace Floricola
{
    public partial class Dashboard : Form
    {
        private readonly menuRendered menuRenderer = new menuRendered();
        public Dashboard()
        {

            InitializeComponent();

            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.AutoSize = true;
            
            //menuStrip1.Width = 220;

            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.BackColor = Color.FromArgb(20, 50, 41);
            menuStrip1.Renderer = menuRenderer;

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.AutoSize = false;
                
                item.Size = new Size(210, 50);
                item.ForeColor = Color.White;
                item.TextAlign = ContentAlignment.MiddleLeft;

                item.Click += SeleccionaItem;

            }
        }
        private void SeleccionaItem(object? sender, EventArgs e)
        {
            menuRenderer.ItemActivo = sender as ToolStripItem;
            menuStrip1.Invalidate();
        }

        private void item_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void itemEstadoCivil_Click(object sender, EventArgs e)
        {
            var estadoCivil = new FrmListaEstadoCivil();
            estadoCivil.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
