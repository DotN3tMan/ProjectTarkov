using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class SimpleItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
