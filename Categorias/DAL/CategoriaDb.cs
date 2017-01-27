using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Categorias.Entidades;

namespace Categorias.DAL
{
    public class CategoriaDb : DbContext
    {
        public CategoriaDb(): base ("ConStr")
        {

        }

        public DbSet <Peliculas> pelicula { get; set; }
    }
}
