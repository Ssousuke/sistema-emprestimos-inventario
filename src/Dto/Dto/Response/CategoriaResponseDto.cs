using System.Text.Json.Serialization;

namespace Dto.Dto.Response
{
    public class CategoriaResponseDto : BaseDto
    {
        [JsonPropertyName("nome_categoria")]
        public string NomeCategoria { get; set; }
    }
}
