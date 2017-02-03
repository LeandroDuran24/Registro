using System.ComponentModel.DataAnnotations;

namespace Categorias.Entidades
{
    public class CategoriaPelicula
    {
        [Key]
        public int  CategoriaId { get; set; }
        public string  Descripcion { get; set; }

        public CategoriaPelicula()
        {

        }
    }
}
