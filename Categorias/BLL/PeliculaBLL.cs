using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Categorias.DAL;
using Categorias.Entidades;

namespace Categorias.BLL
{
    public class PeliculaBLL
    {
        public static void Insertar(Peliculas nuevo) {

         using (var con = new CategoriaDb()) {

                try
                {
                    con.pelicula.Add(nuevo);
                    con.SaveChanges();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
         }

        
        }
        public static void Elimina(Peliculas nuevo)
        {
            var delete = new Peliculas();
            using (var con = new CategoriaDb())
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

        internal static object Elimina(string text)
        {
            throw new NotImplementedException();
        }

        public static Peliculas Buscar(int id) {
            var b = new Peliculas();

            using (var con = new CategoriaDb()) {
                try
                {
                    b = con.pelicula.Find(id);
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
