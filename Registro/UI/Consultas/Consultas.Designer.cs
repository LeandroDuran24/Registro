namespace Registro.UI.Consultas
{
    partial class Consultas
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
            this.CuadrodataGridView1 = new System.Windows.Forms.DataGridView();
            this.ver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CuadrodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CuadrodataGridView1
            // 
            this.CuadrodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuadrodataGridView1.Location = new System.Drawing.Point(12, 22);
            this.CuadrodataGridView1.Name = "CuadrodataGridView1";
            this.CuadrodataGridView1.Size = new System.Drawing.Size(428, 227);
            this.CuadrodataGridView1.TabIndex = 0;
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(188, 255);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 1;
            this.ver.Text = "Ver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 286);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.CuadrodataGridView1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.CuadrodataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CuadrodataGridView1;
        private System.Windows.Forms.Button ver;
    }
}