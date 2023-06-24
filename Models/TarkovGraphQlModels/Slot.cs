using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class Slot
    {
        [JsonPropertyName("nameId")]
        public string Type { get; set; }

        [JsonPropertyName("filters")]
        public Filter Filters { get; set; }
    }
}
