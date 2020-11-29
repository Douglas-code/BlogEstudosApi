using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model
{
    public class UsuarioDebate
    {
        public int UsuarioId { get; set; }
        public int DebateId { get; set; }
        public Usuario Usuario { get; set; }
        public Debate Debate { get; set; }

        public UsuarioDebate() { }

        public UsuarioDebate(int usuarioId, int debateId)
        {
            UsuarioId = usuarioId;
            DebateId = debateId;
        }
    }
}
