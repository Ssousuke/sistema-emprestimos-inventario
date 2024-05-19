using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        public DateTime DataCriacao { get; set; }

        [Column("DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }
    }
}
