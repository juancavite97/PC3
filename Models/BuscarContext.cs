using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace simulacro.Models
{
    public class BuscarContext : DbContext
    {
        public DbSet <Producto> Productos {get;set; }
        public DbSet <Categoria> Categorias {get;set; }

        public BuscarContext(DbContextOptions dco) : base(dco) {}
    }
}