namespace MenuPrincipal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pelicula = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pelicula
            // 
            this.pelicula.BackColor = System.Drawing.SystemColors.GrayText;
            this.pelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelicula.ForeColor = System.Drawing.Color.Blue;
            this.pelicula.Image = ((System.Drawing.Image)(resources.GetObject("pelicula.Image")));
            this.pelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pelicula.Location = new System.Drawing.Point(12, 166);
            this.pelicula.Name = "pelicula";
            this.pelicula.Size = new System.Drawing.Size(92, 41);
            this.pelicula.TabIndex = 0;
            this.pelicula.Text = "Pelicula";
            this.pelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pelicula.UseVisualStyleBackColor = false;
            this.pelicula.Click += new System.EventHandler(this.pelicula_Click);
            // 
            // categoria
            // 
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.Blue;
            this.categoria.Image = ((System.Drawing.Image)(resources.GetObject("categoria.Image")));
            this.categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoria.Location = new System.Drawing.Point(110, 167);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(149, 39);
            this.categoria.TabIndex = 1;
            this.categoria.Text = "Categoria Pelicula";
            this.categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoria.UseVisualStyleBackColor = true;
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            // 
            // usuario
            // 
            this.usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.Blue;
            this.usuario.Image = ((System.Drawing.Image)(resources.GetObject("usuario.Image")));
            this.usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuario.Location = new System.Drawing.Point(265, 166);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(106, 39);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "Usuarios";
            this.usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usuario.UseVisualStyleBackColor = true;
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(171, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elija El Registro Que Usted Desea Ver";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // salir
            // 
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.Blue;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(377, 166);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 38);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(465, 210);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.pelicula);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Menu de Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pelicula;
        private System.Windows.Forms.Button categoria;
        private System.Windows.Forms.Button usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salir;
    }
}

