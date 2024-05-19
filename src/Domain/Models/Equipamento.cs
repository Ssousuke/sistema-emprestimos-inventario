using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("EQUIPAMENTO")]
    public sealed class Equipamento : BaseModel
    {
        [Column("NOME_EQUIPAMENTO")]
        public string NomeEquipamento { get; private set; }

        public Categoria Categoria { get; private set; }

        [Column("CATEGORIA_ID")]
        public int CategoriaId { get; private set; }

        [Column("DESCRICAO")]
        public string Descricao { get; private set; }

        [Column("QUANTIDADE")]
        public int Quantidade { get; private set; }

        public void AtualizarNomeEquipamento(string nomeEquipamento)
        {
            NomeEquipamento = nomeEquipamento;
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public bool RemoverEquipamento(int quantidade)
        {
            if (Quantidade <= quantidade)
            {
                Quantidade -= quantidade;
                return true;
            }

            return false;
        }

        public bool AdicionarEquipamento(int quantidade)
        {
            if (quantidade >= 1)
            {
                Quantidade += quantidade;
                return true;
            }

            return false;
        }
    }
}
