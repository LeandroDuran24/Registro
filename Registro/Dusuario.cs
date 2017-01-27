using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registro.DAL;
using Registro.Entidades;
using Registro.UI.Consultas;

namespace Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();

            usuario.Nombre = NombretextBox2.Text;
            usuario.Clave = ClavemaskedTextBox1.Text;

            if (usuario != null)
            {
                BLL.UsuariosBLL.Insertar(usuario);
                MessageBox.Show("Guardado...");
            }

            NombretextBox2.Text = "";
            ClavemaskedTextBox1.Text = "";
        
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(IdtextBox.Text));

            if (usuario != null)
            {
                NombretextBox2.Text = usuario.Nombre;
                ClavemaskedTextBox1.Text = usuario.Clave;

                MessageBox.Show("Busqueda Correcta...");
            }
            NombretextBox2.Text = "";
            ClavemaskedTextBox1.Text = "";
            IdtextBox.Text = "";


        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            
            Consultas c = new Consultas();
            c.Show();

        }

        private void Elimbutton1_Click(object sender, EventArgs e)
        {
            var eli = BLL.UsuariosBLL.Buscar(Convert.ToInt32(IdtextBox.Text));

            if (eli != null)
            {
                BLL.UsuariosBLL.Eliminar(eli);
                MessageBox.Show("Eliminado...");
                IdtextBox.Text = "";

            }
            else
            {
                MessageBox.Show("No se ha Eliminado...");
            }
        }
    }
}
