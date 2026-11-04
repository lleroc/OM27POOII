using System.Drawing;
using System.Windows.Forms;

namespace Floricola.Recursos
{
    class menuRendered: ToolStripProfessionalRenderer
    {
        public ToolStripItem ItemActivo { get; set; }

        public readonly Color fondo = Color.FromArgb(25, 50, 41);

        public readonly Color hover = Color.FromArgb(50, 100, 80);

        public readonly Color activo = Color.FromArgb(30,120,100);

        public menuRendered()
        {
            RoundedEdges = false;
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using var brush = new SolidBrush(fondo);
            e.Graphics.FillRectangle(brush, e.AffectedBounds);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Color color = fondo;
            if (e.Item == ItemActivo)
            {
                color = activo;
            }
            else if (e.Item.Selected)
            {
                color = hover;
            }
            using var brush = new SolidBrush(color);
            e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //elimna los bordes
        }

    }
}
