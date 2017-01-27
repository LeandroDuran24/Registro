using System;
using System.Windows.Forms;
using Categorias;
using MenuPrincipal;
using Peliculas;
using Registro;
using Registro.Entidades;

namespace MenuPrincipal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void categoria_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.Show();
        }

        private void pelicula_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula();
            p.Show();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
