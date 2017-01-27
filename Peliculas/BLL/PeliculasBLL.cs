using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Peliculas.DAL;
using Peliculas.Entidades;

namespace Peliculas.BLL
{
    public class PeliculasBLL
    {
        public static void Insertar(PeliculasEntidades nuevo) {
            using (var con = new PeliculaDb())
            {

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

       public static PeliculasEntidades Buscar(int id) {
            var buscar = new PeliculasEntidades();
               using(var con = new PeliculaDb()) {
                    try
                    {
                        buscar = con.pelicula.Find(id);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error..."); 
                    }
                }
                return buscar;
       }

     public static void Eliminar(PeliculasEntidades nuevo) {
            var pelicula = new PeliculaDb();
            using (var con = new PeliculaDb()) {
                con.Entry(nuevo).State = EntityState.Deleted;
                con.SaveChanges();
            }
     }
    }
}
