using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model
{
    public class PublicacaoDebate
    {
        public int PublicacaoId { get; set; }
        public int DebateId { get; set; }
        public Publicacao Publicacao { get; set; }
        public Debate Debate { get; set; }
    }
}
