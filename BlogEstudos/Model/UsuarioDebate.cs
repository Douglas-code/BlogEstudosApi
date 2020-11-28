using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model
{
    [Table("tb_usuario_debate")]
    public class UsuarioDebate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("tb_usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("tb_debate")]
        public int DebateId { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Debate> Debates { get; set; }

        public UsuarioDebate() { }

        public UsuarioDebate(int id, int usuarioId, int debateId)
        {
            Id = id;
            UsuarioId = usuarioId;
            DebateId = debateId;
        }
    }
}
