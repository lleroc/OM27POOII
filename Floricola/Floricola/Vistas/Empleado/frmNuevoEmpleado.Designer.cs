namespace Floricola.Vistas.Empleado
{
    partial class frmNuevoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbEstadoCivil = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtCelular = new TextBox();
            label9 = new Label();
            lstEmpleados = new ListBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            txtUsuario = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtContraseña = new TextBox();
            label12 = new Label();
            chbEstado = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, -2);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Empleados";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.Enabled = false;
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(181, 216);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(157, 27);
            cmbEstadoCivil.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 194);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 2;
            label2.Text = "Estado Civil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 3;
            label3.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Enabled = false;
            txtCedula.Location = new Point(12, 52);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(163, 26);
            txtCedula.TabIndex = 4;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Location = new Point(12, 103);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(163, 26);
            txtNombres.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 5;
            label4.Text = "Nombres";
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Location = new Point(12, 158);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(163, 26);
            txtApellidos.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 7;
            label5.Text = "Apellidos";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(12, 217);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(163, 26);
            txtDireccion.TabIndex = 10;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 195);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 9;
            label6.Text = "Direccion";
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(181, 157);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(157, 26);
            txtCorreo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 135);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 11;
            label7.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(181, 51);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 26);
            txtTelefono.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 29);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 13;
            label8.Text = "Telefono";
            // 
            // txtCelular
            // 
            txtCelular.Enabled = false;
            txtCelular.Location = new Point(181, 102);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(157, 26);
            txtCelular.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 80);
            label9.Name = "label9";
            label9.Size = new Size(52, 19);
            label9.TabIndex = 15;
            label9.Text = "Celular";
            label9.Click += label9_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Items.AddRange(new object[] { "Luis Llerena" });
            lstEmpleados.Location = new Point(344, 52);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(131, 194);
            lstEmpleados.TabIndex = 17;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(31, 394);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 56);
            btnNuevo.TabIndex = 18;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(112, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 56);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(193, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 56);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(274, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 56);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(355, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 56);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(39, 313);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(163, 26);
            txtUsuario.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 291);
            label10.Name = "label10";
            label10.Size = new Size(130, 19);
            label10.TabIndex = 23;
            label10.Text = "Nombre de Usuario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 259);
            label11.Name = "label11";
            label11.Size = new Size(131, 19);
            label11.TabIndex = 25;
            label11.Text = "Gestion de Usuarios";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(39, 362);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(163, 26);
            txtContraseña.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 340);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 26;
            label12.Text = "Contraseña";
            // 
            // chbEstado
            // 
            chbEstado.AutoSize = true;
            chbEstado.Enabled = false;
            chbEstado.Location = new Point(274, 336);
            chbEstado.Name = "chbEstado";
            chbEstado.Size = new Size(140, 23);
            chbEstado.TabIndex = 28;
            chbEstado.Text = "Estado de Usuario";
            chbEstado.UseVisualStyleBackColor = true;
            chbEstado.CheckedChanged += chbEstado_CheckedChanged;
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 461);
            ControlBox = false;
            Controls.Add(chbEstado);
            Controls.Add(txtContraseña);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtUsuario);
            Controls.Add(label10);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lstEmpleados);
            Controls.Add(txtCelular);
            Controls.Add(label9);
            Controls.Add(txtTelefono);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(txtApellidos);
            Controls.Add(label5);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoEmpleado";
            Text = "Nuevo Empleado";
            FormClosing += frmNuevoEmpleado_FormClosing;
            Load += frmNuevoEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEstadoCivil;
        private Label label2;
        private Label label3;
        private TextBox txtCedula;
        private TextBox txtNombres;
        private Label label4;
        private TextBox txtApellidos;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtTelefono;
        private Label label8;
        private TextBox txtCelular;
        private Label label9;
        private ListBox lstEmpleados;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtUsuario;
        private Label label10;
        private Label label11;
        private TextBox txtContraseña;
        private Label label12;
        private CheckBox chbEstado;
    }
}