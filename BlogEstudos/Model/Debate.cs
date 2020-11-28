using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEstudos.Model
{
    [Table("tb_debate")]
    public class Debate
    {
        [Key]
        public int Id { get; set; } 
        public string Titulo { get; set; }

        public Debate() { }

        public Debate(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }
    }
}
