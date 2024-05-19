using System.Text.Json.Serialization;

namespace Dto.Dto.Response
{
    public class EquipamentoResponseDto : BaseDto
    {

        [JsonPropertyName("nome_equipamento")]
        public string NomeEquipamento { get; set; }

        [JsonPropertyName("categoria")]
        public CategoriaResponseDto Categoria { get; private set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }
    }
}
