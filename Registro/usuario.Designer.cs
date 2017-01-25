namespace Registro
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox2 = new System.Windows.Forms.TextBox();
            this.ClavemaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Consultas = new System.Windows.Forms.Button();
            this.Elimbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UsuarioId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(142, 30);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox.TabIndex = 3;
            // 
            // NombretextBox2
            // 
            this.NombretextBox2.Location = new System.Drawing.Point(142, 65);
            this.NombretextBox2.Name = "NombretextBox2";
            this.NombretextBox2.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox2.TabIndex = 4;
            // 
            // ClavemaskedTextBox1
            // 
            this.ClavemaskedTextBox1.Location = new System.Drawing.Point(142, 99);
            this.ClavemaskedTextBox1.Mask = "9999-9999";
            this.ClavemaskedTextBox1.Name = "ClavemaskedTextBox1";
            this.ClavemaskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ClavemaskedTextBox1.TabIndex = 5;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(31, 156);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(260, 27);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Consultas
            // 
            this.Consultas.Location = new System.Drawing.Point(260, 155);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(75, 23);
            this.Consultas.TabIndex = 9;
            this.Consultas.Text = "Consultas";
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            // 
            // Elimbutton1
            // 
            this.Elimbutton1.Location = new System.Drawing.Point(142, 155);
            this.Elimbutton1.Name = "Elimbutton1";
            this.Elimbutton1.Size = new System.Drawing.Size(75, 23);
            this.Elimbutton1.TabIndex = 10;
            this.Elimbutton1.Text = "Eliminar";
            this.Elimbutton1.UseVisualStyleBackColor = true;
            Elimbutton1.Click += new System.EventHandler(Elimbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.Elimbutton1);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.ClavemaskedTextBox1);
            this.Controls.Add(this.NombretextBox2);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox NombretextBox2;
        private System.Windows.Forms.MaskedTextBox ClavemaskedTextBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Consultas;
        private System.Windows.Forms.Button Elimbutton1;
    }
}

