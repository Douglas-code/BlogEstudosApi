using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<UsuarioMateria> UsuariosMaterias { get; set; }

        public Materia() { }

        public Materia(int id, string nome) 
        {
            Id = id;
            Nome = nome;
        }
    }
}
