using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Peliculas.DAL;
using Peliculas.Entidades;

namespace Peliculas.UI.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void verbutton1_Click(object sender, EventArgs e)
        {
            List<PeliculasEntidades> pe = new List<PeliculasEntidades>();
            var lis = new PeliculaDb();
            pe = lis.pelicula.ToList();
            dataGridView1.DataSource = pe;
        }
    }
}
