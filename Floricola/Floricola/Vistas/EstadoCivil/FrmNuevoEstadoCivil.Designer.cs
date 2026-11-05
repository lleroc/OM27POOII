namespace Floricola.Vistas.EstadoCivil
{
    partial class FrmNuevoEstadoCivil
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
            label1 = new Label();
            txtNuevo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 111);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la Descripcion";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(12, 72);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(147, 23);
            txtNuevo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 3;
            label2.Text = "Nuevo Estado Civil";
            // 
            // FrmNuevoEstadoCivil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 147);
            Controls.Add(label2);
            Controls.Add(txtNuevo);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "FrmNuevoEstadoCivil";
            Text = "FrmNuevoEstadoCivil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private TextBox txtNuevo;
        private Label label2;
    }
}