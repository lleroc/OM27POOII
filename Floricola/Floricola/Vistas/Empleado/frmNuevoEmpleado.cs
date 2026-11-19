using Floricola.Controladores;
using Floricola.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

using Floricola.Modelos;
using Floricola.Modelos.ViewModel;
namespace Floricola.Vistas.Empleado
{
    public partial class frmNuevoEmpleado : Form
    {
        bool editar = false;
        Validaciones _validaciones = new Validaciones();
        private readonly EstadoCivilController _estadoCivil = new EstadoCivilController();
        private readonly EmpleadoController _empleadoController = new EmpleadoController();
        public frmNuevoEmpleado()
        {
            InitializeComponent();
            _validaciones.SoloNumeros(txtCedula, 10);
            editar = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevoEmpleado_Load(object sender, EventArgs e)
        {
            cmbEstadoCivil.DataSource = _estadoCivil.ListarEstadoCivil();
            cmbEstadoCivil.DisplayMember = "descripcion";
            cmbEstadoCivil.ValueMember = "id";  

            cmbEstadoCivil.SelectedIndex = -1; // Selecciona un valor predeterminado (opcional)
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList; // Evita que el usuario escriba en el ComboBox

            ListaEmpleados();

        }

        public void ListaEmpleados() {
            lstEmpleados.DataSource = null;
            lstEmpleados.Items.Clear();

            lstEmpleados.DataSource = _empleadoController.todos();
            lstEmpleados.DisplayMember = "Nombres";
            lstEmpleados.ValueMember = "id";

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
            this.Hide();
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

                UEmpleadoViewModel empleadoSeleccionado =  new UEmpleadoViewModel();    
                empleadoSeleccionado = 
                    _empleadoController.uno((int)lstEmpleados.SelectedValue);  

                txtNombres.Text = empleadoSeleccionado.Nombres;
                txtApellidos.Text = empleadoSeleccionado.Apellidos;
                txtCedula.Text = empleadoSeleccionado.Cedula;
                txtDireccion.Text = empleadoSeleccionado.Direccion;
                txtTelefono.Text = empleadoSeleccionado.Telefono;
                txtCelular.Text = empleadoSeleccionado.Celular;
                txtCorreo.Text = empleadoSeleccionado.Correo;
                cmbEstadoCivil.SelectedValue = empleadoSeleccionado.EstadoCivilModelId;

                chbEstado.Checked = empleadoSeleccionado.Activo; 

                txtUsuario.Text = empleadoSeleccionado.Nombre_Usuario;
                txtContraseña.Text = empleadoSeleccionado.Password;
                lblIdUsuario.Text = empleadoSeleccionado.UsuarioId.ToString();
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
                    int idempleado = (int)lstEmpleados.SelectedValue;
                    
                    var eliminacion = _empleadoController.eliminar(idempleado);
                    if (eliminacion) {
                        MessageBox.Show("Empleado eliminado correctamente.");
                        DesactivarCajas();
                        ListaEmpleados();
                    }
                    
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
                    var empleado = new EmpleadoModel
                    {
                        Id = (int)lstEmpleados.SelectedValue,
                        Cedula = txtCedula.Text,
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Celular = txtCelular.Text,
                        Correo = txtCorreo.Text,
                        EstadoCivilModelId = (int)cmbEstadoCivil.SelectedValue
                    };

                    var usuario = new UsuarioModel
                    {
                        Id = Convert.ToInt32(lblIdUsuario.Text),
                        Nombre_Usuario = txtUsuario.Text,
                        Password = txtContraseña.Text,
                        EstadoCivilModelId = empleado.Id
                    };

                    var resultado = _empleadoController.editar(empleado, usuario);
                    if (resultado != null)
                    {
                        editar = false;

                        MessageBox.Show("Empleado guardado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el empleado.");
                    }
                }
                else
                {
                    var empleado = new EmpleadoModel
                    {
                        Cedula = txtCedula.Text,
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Celular = txtCelular.Text,
                        Correo = txtCorreo.Text,
                        EstadoCivilModelId = (int)cmbEstadoCivil.SelectedValue
                    };

                    var usuario = new UsuarioModel
                    {
                        Nombre_Usuario = txtUsuario.Text,
                        Password = txtContraseña.Text,
                        EstadoCivilModelId = empleado.Id
                    };

                    var resultado = _empleadoController.nuevo(empleado, usuario);
                    if (resultado != null)
                    {
                        MessageBox.Show("Empleado guardado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el empleado.");
                    }
                }
                DesactivarCajas();
                ListaEmpleados();
            }
        }

        private void frmNuevoEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
            Environment.Exit(0);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            var respuesta = _validaciones.ValidarCedulaEcuatoriana(txtCedula.Text);
            if (!respuesta)
            {
                MessageBox.Show("La cédula ingresada no es válida. Por favor, verifique el número de cédula.");
                txtCedula.Focus();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());  
            //MessageBox.Show(char.IsDigit(e.KeyChar).ToString());
            _validaciones.SoloNumeros_KeyPress(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validaciones.SoloNumeros_KeyPress(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validaciones.SoloNumeros_KeyPress(sender, e);
           

        }

        private void cmbEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Evita que se escriba en el ComboBox
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 
