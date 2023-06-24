using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class Weapon
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }

    }
}
