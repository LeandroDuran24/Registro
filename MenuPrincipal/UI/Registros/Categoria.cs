using System;
using System.Windows.Forms;
using Categorias.Entidades;
using Categorias.UI.Consultas;

namespace Categorias
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var g = new CategoriaPelicula();
            g.Descripcion = DtextBox2.Text;

            if( g != null) {
                BLL.CategoriaBLL.Insertar(g);
                MessageBox.Show("Guardado...");
            }
   
            IdtextBox1.Text = "";
            DtextBox2.Text = "";

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            c.Show();
        }

       private void Eliminar_Click(object sender, EventArgs e)
        {


            var de = BLL.CategoriaBLL.Buscar (Convert.ToInt32(IdtextBox1.Text)) ;

            if (de != null)
            {
                BLL.CategoriaBLL.Elimina(de);
                MessageBox.Show("Eliminado...");
                IdtextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("No se ha Eliminado...");
            }
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var bus= BLL.CategoriaBLL.Buscar(Convert.ToInt32(IdtextBox1.Text));

            if (bus!= null)
            {

                DtextBox2.Text = bus.Descripcion;
                MessageBox.Show("Busqueda Correcta...");
            }
            IdtextBox1.Text = "";
            DtextBox2.Text = "";
            
        }
    }
}
