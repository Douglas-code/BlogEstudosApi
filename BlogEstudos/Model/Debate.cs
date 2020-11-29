using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    public class Debate
    {
        [Key]
        public int Id { get; set; } 
        public string Titulo { get; set; }
        public ICollection<UsuarioDebate> UsuarioDebates { get; set; }

        public Debate() { }

        public Debate(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }
    }
}
