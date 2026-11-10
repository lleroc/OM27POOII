using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace Floricola.Vistas.Empleado
{
    public partial class frmNuevoEmpleado : Form
    {
        bool editar = false;
        public frmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void chbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstado.Checked)
            {
                chbEstado.Text = "El usuario esta activo";
            }
            else
            {
                chbEstado.Text = "El usuario esta inactivo";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex != -1)
            {
                editar = true;
                ActivarCajas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado para editar");
            }
        }

        public void ActivarCajas()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            lstEmpleados.Enabled = false;

            txtApellidos.Enabled = true;
            txtCedula.Enabled = true;
            txtCelular.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtNombres.Enabled = true;
            txtTelefono.Enabled = true;
            txtNombres.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            chbEstado.Enabled = true;
            cmbEstadoCivil.Enabled = true;

        }
        public void DesactivarCajas()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            lstEmpleados.Enabled = true;

            txtApellidos.Enabled = false;
            txtCedula.Enabled = false;
            txtCelular.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtNombres.Enabled = false;
            txtTelefono.Enabled = false;
            txtNombres.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            chbEstado.Enabled = false;
            cmbEstadoCivil.Enabled = false;



            txtApellidos.Text = "";
            txtCedula.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtNombres.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            chbEstado.Checked = false;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el empleado seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Aquí puedes agregar la lógica para eliminar el empleado seleccionado
                    MessageBox.Show("Empleado eliminado correctamente.");
                    DesactivarCajas();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de guardar los cambios?",
                    "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (editar)
                {
                    // Aquí puedes agregar la lógica para actualizar el empleado existente
                    MessageBox.Show("Empleado actualizado correctamente.");
                }
                else
                {
                    // Aquí puedes agregar la lógica para guardar un nuevo empleado
                    MessageBox.Show("Empleado guardado correctamente.");
                }
                DesactivarCajas();
            }
        }

        private void frmNuevoEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Debugger.Break();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}

 
