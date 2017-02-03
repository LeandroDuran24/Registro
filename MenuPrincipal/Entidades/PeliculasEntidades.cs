using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Peliculas.Entidades
{
    public class PeliculasEntidades
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Extreno { get; set; }
        public string Descripcion { get; set; }
        public string CategoriaID { get; set; }

        public PeliculasEntidades()
        {

        }
    }
}
