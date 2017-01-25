using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registro.DAL;
using Registro.Entidades;

namespace Registro.BLL
{
   public  class UsuariosBLL
    {
        public static void Insertar(Usuarios nuevo) {
            using (var conn = new UsuarioDb()) { 
                try
                {
                        conn.user.Add(nuevo);
                        conn.SaveChanges();
                      
                 }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
             
            }
            
        }

        public static Usuarios Buscar(int Id)
        {
            var usuario = new Usuarios();
            using (var conn = new UsuarioDb())
            {
                try
                {
                    usuario = conn.user.Find(Id);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error...");
                }
                

            }

            return usuario;

        }

        public static void  Eliminar(Usuarios nuevo)
        {
            var usuario = new Usuarios();
            using (var conn = new UsuarioDb()) {
                try
                {
                    conn.Entry(nuevo).State = EntityState.Deleted;
                    conn.SaveChanges();
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Error...");
                                   
                }

         }
            
        }
    }
}
