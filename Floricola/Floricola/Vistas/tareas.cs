using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Floricola
{
    public partial class tareas : Form
    {
        public tareas()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lst_lista.Items.Add(txt_tarea.Text);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_lista.Items.Remove(lst_lista.SelectedItem);
        }
    }
}
