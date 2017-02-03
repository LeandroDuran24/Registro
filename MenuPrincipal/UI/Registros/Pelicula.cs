using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Peliculas.Entidades;
using Peliculas.UI.Consultas;

namespace Peliculas
{
    public partial class Pelicula : Form
    {
        public Pelicula()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var pelicula = new PeliculasEntidades();
            pelicula.Extreno = extrenoMaskedTextBox.Text;
            pelicula.Descripcion = descripcionTextBox.Text;
            pelicula.CategoriaID = categoriaIdTextBox.Text;

            if (pelicula != null)
            {
                BLL.PeliculasBLL.Insertar(pelicula);
                MessageBox.Show("Guardado");

            }
            extrenoMaskedTextBox.Text = "";
            descripcionTextBox.Text = "";
            categoriaIdTextBox.Text = "";
        }

        private void Buscarbutton3_Click(object sender, EventArgs e)
        {
            var buscar = BLL.PeliculasBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));

            if(buscar != null) {
                extrenoMaskedTextBox.Text = buscar.Extreno;
                categoriaIdTextBox.Text = buscar.CategoriaID;
                descripcionTextBox.Text = buscar.Descripcion;
                MessageBox.Show("Busqueda Correcta");
            }

            extrenoMaskedTextBox.Text = "";
            categoriaIdTextBox.Text = "";
            descripcionTextBox.Text = "";
            peliculaIdTextBox.Text = "";
        }

        private void Eliminarbutton2_Click(object sender, EventArgs e)
        {
            var elim = BLL.PeliculasBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));
            if(elim != null) {
                BLL.PeliculasBLL.Eliminar(elim);
                MessageBox.Show("Eliminado...");
            }
            else {
                MessageBox.Show("No se ha Elimimnado...");
            }
        }

        private void Consultasbutton1_Click(object sender, EventArgs e)
        {
            ConsultasPelicula c = new ConsultasPelicula();
            c.Show();
        }
    }
}
