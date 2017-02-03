using System.Data.Entity;
using Categorias.Entidades;
using Peliculas.Entidades;
using Registro.Entidades;



namespace Registro.DAL
{
    public class RegistroDb : DbContext

    {
        public RegistroDb(): base ("ConStr")
        {

        }

        public DbSet <Usuarios> user { get; set; }
        public DbSet<PeliculasEntidades> pelicula  { get; set; }
        public DbSet <CategoriaPelicula> categoria  { get; set; }
    }
}
