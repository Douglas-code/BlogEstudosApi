using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogEstudos.Model
{
    [Table("tb_publicacao_materia")]
    public class PublicacaoMateria
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("tb_publicacao")]
        public int PublicacaoId { get; set; }
        [ForeignKey("tb_materia")]
        public int MateriaId { get; set; }
        public ICollection<Publicacao> Publicacacoes { get; set; }
        public ICollection<Materia> Materias { get; set; }

        public PublicacaoMateria() { }

        public PublicacaoMateria(int id, int publicacaoId, int materiaId)
        {
            Id = id;
            PublicacaoId = publicacaoId;
            MateriaId = materiaId;
        }
    }
}
