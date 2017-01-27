using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Categorias.DAL;
using Categorias.Entidades;

namespace Categorias.UI.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Peliculas> p = new List<Peliculas>();
            var ver = new CategoriaDb();
            p = ver.pelicula.ToList();
            dataGridView1.DataSource = p;
           

        }
    }
}
