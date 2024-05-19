using System.Text.Json.Serialization;

namespace Dto.Dto.Request
{
    public sealed class EquipamentoRequestDto
    {
        [JsonPropertyName("nome_equipamento")]
        public string NomeEquipamento { get; set; }

        [JsonPropertyName("categoria_id")]
        public int CategoriaId { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }
    }
}
