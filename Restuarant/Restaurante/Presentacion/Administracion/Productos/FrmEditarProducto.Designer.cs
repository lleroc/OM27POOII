namespace Restaurante.Presentacion.Administracion.Productos
{
    partial class FrmEditarProducto
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
            btnGuardar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            nudPVP = new NumericUpDown();
            nudPC = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPVP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPC).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(30, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 46);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(147, 272);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 46);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 3;
            label1.Text = "Editar Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 32);
            txtNombre.TabIndex = 4;
            // 
            // nudPVP
            // 
            nudPVP.DecimalPlaces = 2;
            nudPVP.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nudPVP.Location = new Point(50, 158);
            nudPVP.Name = "nudPVP";
            nudPVP.Size = new Size(120, 32);
            nudPVP.TabIndex = 7;
            // 
            // nudPC
            // 
            nudPC.DecimalPlaces = 2;
            nudPC.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nudPC.Location = new Point(50, 221);
            nudPC.Name = "nudPC";
            nudPC.Size = new Size(120, 32);
            nudPC.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 67);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 9;
            label2.Text = "Nombre de Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 130);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 10;
            label3.Text = "PVP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 11;
            label4.Text = "Precio de Costo";
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 382);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudPC);
            Controls.Add(nudPVP);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmEditarProducto";
            Text = "FrmNuevoProducto";
            Load += FrmEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPVP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtNombre;
        private NumericUpDown nudPVP;
        private NumericUpDown nudPC;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}