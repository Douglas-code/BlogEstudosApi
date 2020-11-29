using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    public class Debate
    {
        public int Id { get; set; } 
        public string Titulo { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public ICollection<PublicacaoDebate> PublicacoesDebates { get; set; }
        public ICollection<UsuarioDebate> UsuariosDebates { get; set; }

        public Debate() { }

        public Debate(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }
    }
}
