using BlogEstudos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }
  
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Debate> Debates { get; set; }
    }
}
