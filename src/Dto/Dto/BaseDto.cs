using System.Text.Json.Serialization;

namespace Dto.Dto
{
    public abstract class BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("data_descricao")]
        public DateTime DataCriacao { get; set; }

        [JsonPropertyName("data_atualizacao")]
        public DateTime DataAtualizacao { get; set; }
    }
}
