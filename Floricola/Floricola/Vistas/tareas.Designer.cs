namespace Floricola
{
    partial class tareas
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
            btn_agregar = new Button();
            lst_lista = new ListBox();
            btn_eliminar = new Button();
            txt_tarea = new TextBox();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(12, 235);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lst_lista
            // 
            lst_lista.FormattingEnabled = true;
            lst_lista.Location = new Point(65, 81);
            lst_lista.Name = "lst_lista";
            lst_lista.Size = new Size(120, 94);
            lst_lista.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(110, 235);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txt_tarea
            // 
            txt_tarea.Location = new Point(65, 35);
            txt_tarea.Name = "txt_tarea";
            txt_tarea.Size = new Size(100, 23);
            txt_tarea.TabIndex = 3;
            // 
            // tareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(txt_tarea);
            Controls.Add(btn_eliminar);
            Controls.Add(lst_lista);
            Controls.Add(btn_agregar);
            Name = "tareas";
            Text = "tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private ListBox lst_lista;
        private Button btn_eliminar;
        private TextBox txt_tarea;
    }
}