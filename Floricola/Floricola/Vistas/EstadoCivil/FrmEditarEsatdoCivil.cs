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
    public partial class FrmEditarEsatdoCivil : Form
    {
        private readonly EstadoCivilController _estadoCivilController;
        private int idEstadoCivil;
        public FrmEditarEsatdoCivil(EstadoCivilController estadoCivilController, 
            EstadoCivilModel estadoCivil)
        {
            InitializeComponent();
            _estadoCivilController = estadoCivilController;
            idEstadoCivil = estadoCivil.Id;
            txtEditar.Text = estadoCivil.Descripcion;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEditar.Text.Trim() == "") { 
                MessageBox.Show("El campo de edición no puede estar vacío", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                EstadoCivilModel estado =new EstadoCivilModel
                {
                    Id = idEstadoCivil,
                    Descripcion = txtEditar.Text
                };  
                _estadoCivilController.EditarEstadoCivil(estado);
                MessageBox.Show("Estado civil editado correctamente", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al editar el estado civil: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
