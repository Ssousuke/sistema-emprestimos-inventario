using System.Text.Json.Serialization;

namespace Dto.Dto.Request
{
    public sealed class CategoriaRequestDto
    {
        [JsonPropertyName("nome_categoria")]
        public string NomeCategoria { get; set; }
    }
}
