using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class Filter
    {
        [JsonPropertyName("allowedItems")]
        public SimpleItem[] IdsAllowed { get; set; }
    }
}
