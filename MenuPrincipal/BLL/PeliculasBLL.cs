using System;
using System.Data.Entity;
using System.Windows.Forms;
using Peliculas.Entidades;
using Registro.DAL;

namespace Peliculas.BLL
{
    public class PeliculasBLL
    {
        public static void Insertar(PeliculasEntidades nuevo) {
            using (var con = new RegistroDb())
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
               using(var con = new RegistroDb()) {
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
            var pelicula = new RegistroDb();
            using (var con = new RegistroDb()) {
                con.Entry(nuevo).State = EntityState.Deleted;
                con.SaveChanges();
            }
     }
    }
}
