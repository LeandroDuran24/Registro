using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Peliculas.Entidades;
using Registro.DAL;

namespace Peliculas.UI.Consultas
{
    public partial class ConsultasPelicula : Form
    {
        public ConsultasPelicula()
        {
            InitializeComponent();
        }

        private void verbutton1_Click(object sender, EventArgs e)
        {
            List<PeliculasEntidades> pe = new List<PeliculasEntidades>();
            var lis = new RegistroDb();
            pe = lis.pelicula.ToList();
            dataGridView1.DataSource = pe;
        }
    }
}
