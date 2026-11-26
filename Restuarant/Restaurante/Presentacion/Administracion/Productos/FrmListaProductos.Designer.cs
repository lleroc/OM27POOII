namespace Restaurante.Presentacion.Administracion.Productos
{
    partial class FrmListaProductos
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
            button1 = new Button();
            label1 = new Label();
            lstListaproductos = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(15, 251);
            button1.Name = "button1";
            button1.Size = new Size(111, 46);
            button1.TabIndex = 0;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista de Productos";
            // 
            // lstListaproductos
            // 
            lstListaproductos.Font = new Font("Segoe UI", 14F);
            lstListaproductos.FormattingEnabled = true;
            lstListaproductos.Location = new Point(15, 61);
            lstListaproductos.Name = "lstListaproductos";
            lstListaproductos.Size = new Size(345, 179);
            lstListaproductos.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(132, 251);
            button2.Name = "button2";
            button2.Size = new Size(111, 46);
            button2.TabIndex = 3;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(249, 251);
            button3.Name = "button3";
            button3.Size = new Size(111, 46);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 309);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lstListaproductos);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmListaProductos";
            Text = "FrmListaProductos";
            Activated += FrmListaProductos_Activated;
            Load += FrmListaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ListBox lstListaproductos;
        private Button button2;
        private Button button3;
    }
}