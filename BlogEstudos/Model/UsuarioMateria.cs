using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    public class UsuarioMateria
    {
        public int UsuarioId {get; set;}
        public int MateriaId { get; set; }
        public Usuario Usuario { get; set; }
        public Materia Materia { get; set; }

        public UsuarioMateria() { }

        public UsuarioMateria(int usuarioId, int materiaId)
        {
            
            UsuarioId = usuarioId;
            MateriaId = materiaId;
        }
    }
}
