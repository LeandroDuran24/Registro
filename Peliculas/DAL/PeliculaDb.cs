using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Peliculas.Entidades;

namespace Peliculas.DAL
{
   public  class PeliculaDb : DbContext
    {
        public PeliculaDb(): base("ConStr")
        {
                
        }

        public DbSet <PeliculasEntidades> pelicula { get; set; }
    }
}
