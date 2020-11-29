using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model
{
    public class Publicacao
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int UsuarioId { get; set; }
        public int MateriaId { get; set; }
        public Usuario Usuario { get; set; }
        public Materia Materia { get; set; }

        public Publicacao() { }

        public Publicacao(int id, DateTime dataPublicacao, string titulo, string conteudo, int usuarioId)
        {
            Id = id;
            DataPublicacao = dataPublicacao;
            Titulo = titulo;
            Conteudo = conteudo;
            UsuarioId = usuarioId;
        }
    }
}
