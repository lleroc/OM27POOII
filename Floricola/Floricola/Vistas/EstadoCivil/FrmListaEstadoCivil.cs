using Floricola.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Floricola.Vistas.EstadoCivil
{
    public partial class FrmListaEstadoCivil : Form
    {
        public readonly EstadoCivilController estadoCivil = new EstadoCivilController();
        public FrmListaEstadoCivil()
        {
            InitializeComponent();
            btnNuevo.BackColor = Color.FromArgb(25, 50, 41);
            btnNuevo.ForeColor = Color.White;

            btnEditar.BackColor = Color.FromArgb(25, 50, 41);
            btnEditar.ForeColor = Color.White;

            btnEliminar.BackColor = Color.FromArgb(25, 50, 41);
            btnEliminar.ForeColor = Color.White;

        }

        private void FrmListaEstadoCivil_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            lstLista.DataSource = null;
            lstLista.DataSource = estadoCivil.ListarEstadoCivil();
            lstLista.DisplayMember = "Descripcion";
            lstLista.ValueMember = "Id";
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEstadoCivil = new FrmNuevoEstadoCivil();
            await frmNuevoEstadoCivil.ShowDialogAsync();
            CargarDatos();
        }
    }
}
