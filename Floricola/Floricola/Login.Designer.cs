namespace Floricola
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(3, 22, 52);
            label1.Location = new Point(0, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(3, 22, 52);
            button2.Location = new Point(104, 194);
            button2.Name = "button2";
            button2.Size = new Size(54, 31);
            button2.TabIndex = 2;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(3, 22, 52);
            label2.Location = new Point(23, 67);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 3;
            label2.Text = "Ingrese su Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(3, 22, 52);
            label3.Location = new Point(23, 123);
            label3.Name = "label3";
            label3.Size = new Size(177, 21);
            label3.TabIndex = 4;
            label3.Text = "Ingrese su Contraseña";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(3, 22, 52);
            textBox1.Location = new Point(23, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(3, 22, 52);
            textBox2.Location = new Point(23, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 29);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(3, 22, 52);
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 7;
            label4.Text = "Mensaje";
            // 
            // button3
            // 
            button3.Location = new Point(23, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 8;
            button3.Text = "Ingresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 221, 203);
            ClientSize = new Size(228, 364);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "FloriSoft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button3;
    }
}
