using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model
{
    [Table("tb_usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public ICollection<UsuarioDebate> UsuarioDebates { get; set; }
        public ICollection<UsuarioMateria> UsuariosMaterias { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
        }
    }
}
