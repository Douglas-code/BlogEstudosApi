using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    [Table("tb_materia")]
    public class UsuarioMateria
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("tb_usuario")]
        public int UsuarioId {get; set;}
        [ForeignKey("tb_materia")]
        public int MateriaId { get; set; }
        public Usuario Usuario { get; set; }
        public Materia Materia { get; set; }

        public UsuarioMateria() { }

        public UsuarioMateria(int id, int usuarioId, int materiaId)
        {
            Id = id;
            UsuarioId = usuarioId;
            MateriaId = materiaId;
        }
    }
}
