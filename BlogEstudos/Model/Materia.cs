using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    [Table("tb_materia")]
    public class Materia
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Materia() { }

        public Materia(int id, string nome) 
        {
            Id = id;
            Nome = nome;
        }
    }
}
