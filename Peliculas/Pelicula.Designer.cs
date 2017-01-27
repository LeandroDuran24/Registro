namespace Peliculas
{
    partial class Pelicula
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
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label extrenoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.extrenoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Consultasbutton1 = new System.Windows.Forms.Button();
            this.Eliminarbutton2 = new System.Windows.Forms.Button();
            this.Buscarbutton3 = new System.Windows.Forms.Button();
            peliculaIdLabel = new System.Windows.Forms.Label();
            extrenoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(105, 74);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // extrenoLabel
            // 
            extrenoLabel.AutoSize = true;
            extrenoLabel.Location = new System.Drawing.Point(105, 100);
            extrenoLabel.Name = "extrenoLabel";
            extrenoLabel.Size = new System.Drawing.Size(46, 13);
            extrenoLabel.TabIndex = 3;
            extrenoLabel.Text = "Extreno:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(97, 159);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(97, 130);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 7;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Location = new System.Drawing.Point(178, 71);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.peliculaIdTextBox.TabIndex = 100;
            // 
            // extrenoMaskedTextBox
            // 
            this.extrenoMaskedTextBox.Location = new System.Drawing.Point(178, 97);
            this.extrenoMaskedTextBox.Mask = "00/00/0000";
            this.extrenoMaskedTextBox.Name = "extrenoMaskedTextBox";
            this.extrenoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.extrenoMaskedTextBox.TabIndex = 0;
            this.extrenoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(178, 149);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(154, 54);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // categoriaIdTextBox
            // 
            this.categoriaIdTextBox.Location = new System.Drawing.Point(178, 123);
            this.categoriaIdTextBox.Name = "categoriaIdTextBox";
            this.categoriaIdTextBox.Size = new System.Drawing.Size(154, 20);
            this.categoriaIdTextBox.TabIndex = 1;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(22, 226);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Consultasbutton1
            // 
            this.Consultasbutton1.Location = new System.Drawing.Point(137, 226);
            this.Consultasbutton1.Name = "Consultasbutton1";
            this.Consultasbutton1.Size = new System.Drawing.Size(75, 23);
            this.Consultasbutton1.TabIndex = 4;
            this.Consultasbutton1.Text = "Consultas";
            this.Consultasbutton1.UseVisualStyleBackColor = true;
            this.Consultasbutton1.Click += new System.EventHandler(this.Consultasbutton1_Click);
            // 
            // Eliminarbutton2
            // 
            this.Eliminarbutton2.Location = new System.Drawing.Point(242, 226);
            this.Eliminarbutton2.Name = "Eliminarbutton2";
            this.Eliminarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton2.TabIndex = 5;
            this.Eliminarbutton2.Text = "Eliminar";
            this.Eliminarbutton2.UseVisualStyleBackColor = true;
            this.Eliminarbutton2.Click += new System.EventHandler(this.Eliminarbutton2_Click);
            // 
            // Buscarbutton3
            // 
            this.Buscarbutton3.Location = new System.Drawing.Point(284, 71);
            this.Buscarbutton3.Name = "Buscarbutton3";
            this.Buscarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton3.TabIndex = 6;
            this.Buscarbutton3.Text = "Buscar";
            this.Buscarbutton3.UseVisualStyleBackColor = true;
            this.Buscarbutton3.Click += new System.EventHandler(this.Buscarbutton3_Click);
            // 
            // Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.Buscarbutton3);
            this.Controls.Add(this.Eliminarbutton2);
            this.Controls.Add(this.Consultasbutton1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(extrenoLabel);
            this.Controls.Add(this.extrenoMaskedTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdTextBox);
            this.Name = "Pelicula";
            this.Text = "Pelicula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.MaskedTextBox extrenoMaskedTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Consultasbutton1;
        private System.Windows.Forms.Button Eliminarbutton2;
        private System.Windows.Forms.Button Buscarbutton3;
    }
}

