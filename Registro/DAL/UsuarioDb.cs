using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Registro.Entidades;

namespace Registro.DAL
{
    public class UsuarioDb : DbContext

    {
        public UsuarioDb(): base ("ConStr")
        {

        }

        public DbSet <Usuarios> user { get; set; }
    }
}
