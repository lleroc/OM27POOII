namespace Floricola.Vistas.EstadoCivil
{
    partial class FrmListaEstadoCivil
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
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 97);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(126, 51);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo Estado Civil";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 154);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 51);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar Estado Civil";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 211);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 51);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Estado Civil";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Estados Civiles";
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(159, 97);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(137, 169);
            lstLista.TabIndex = 4;
            // 
            // FrmListaEstadoCivil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 275);
            Controls.Add(lstLista);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmListaEstadoCivil";
            Text = "FrmListaEstadoCivil";
            Load += FrmListaEstadoCivil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private ListBox lstLista;
    }
}