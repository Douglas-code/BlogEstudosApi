using BlogEstudos.Model;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<PublicacaoMateria> PublicacoesMaterias { get; set; }
        public DbSet<UsuarioDebate> UsuariosDebates { get; set; }
        public DbSet<UsuarioMateria> UsuariosMaterias { get; set; }
    }
}
