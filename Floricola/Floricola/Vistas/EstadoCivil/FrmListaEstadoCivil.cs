using Floricola.Controladores;
using Floricola.Modelos;
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
        public readonly EstadoCivilController _estadoCivil = new EstadoCivilController();
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
            lstLista.DataSource = _estadoCivil.ListarEstadoCivil();
            lstLista.DisplayMember = "Descripcion";
            lstLista.ValueMember = "Id";
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEstadoCivil = new FrmNuevoEstadoCivil(_estadoCivil);
            await frmNuevoEstadoCivil.ShowDialogAsync();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstLista.Items.Count == 0)
            {
                MessageBox.Show("No hay estados civiles para editar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstLista.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado civil para editar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmeditar = new FrmEditarEsatdoCivil(_estadoCivil,
                    (EstadoCivilModel)lstLista.SelectedItem);
                frmeditar.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (lstLista.Items.Count == 0)
            {
                MessageBox.Show("No hay estados civiles para editar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstLista.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado civil para editar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", 
                    "Confirmar eliminación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (_estadoCivil.EliminarEstadoCivil((EstadoCivilModel)lstLista.SelectedItem))
                    {
                        MessageBox.Show("Estado civil eliminado correctamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el estado civil", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { 
                    MessageBox.Show("Eliminación cancelada", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

        }
    }
}
