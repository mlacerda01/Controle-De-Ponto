using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDePonto.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }

        public DbSet<RegistroPonto> RegistroPonto { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
