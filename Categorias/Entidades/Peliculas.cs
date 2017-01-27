using System.ComponentModel.DataAnnotations;

namespace Categorias.Entidades
{
    public class Peliculas
    {
         [Key]
        public int  CategoriaId { get; set; }
        public string  Descripcion { get; set; }

        public Peliculas()
        {

        }
    }
}
