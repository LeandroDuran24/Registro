using System;
using System.Data.Entity;
using System.Windows.Forms;
using Categorias.Entidades;
using Registro.DAL;

namespace Categorias.BLL
{
    public class CategoriaBLL
    {
        public static void Insertar(CategoriaPelicula nuevo) {

         using (var con = new RegistroDb()) {

                try
                {
                    con.categoria.Add(nuevo);
                    con.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error...");
                }
         }
        
        }
        public static void Elimina(CategoriaPelicula nuevo)
        {
            var delete = new CategoriaPelicula();
            using (var con = new RegistroDb())
            {

                try
                {
                    con.Entry(nuevo).State = EntityState.Deleted;
                    con.SaveChanges();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
            }

        }

       
        public static Entidades.CategoriaPelicula Buscar(int id) {
            var b = new Entidades.CategoriaPelicula();

            using (var con = new RegistroDb()) {
                try
                {
                    b = con.categoria.Find(id);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
            }
            return b;
            }
    }
}
