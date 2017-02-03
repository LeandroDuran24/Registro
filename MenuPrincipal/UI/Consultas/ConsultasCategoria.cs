using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registro.DAL;

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
            List<Entidades.CategoriaPelicula> p = new List<Entidades.CategoriaPelicula>();
            var ver = new RegistroDb();
            p = ver.categoria.ToList();
            dataGridView1.DataSource = p;
           

        }
    }
}
