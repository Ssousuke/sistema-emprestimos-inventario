using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [Table(name: "CATEGORIA")]
    public sealed class Categoria : BaseModel
    {
        [Column("NOME_CATEGORIA")]
        public string NomeCategoria { get; private set; }

        public IEnumerable<Equipamento>? Equipamentos { get; private set; }

        public void AtualizarCategoria(string nome)
        {
            NomeCategoria = nome;
        }
    }
}
