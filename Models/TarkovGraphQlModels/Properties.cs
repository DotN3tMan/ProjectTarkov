using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class Properties
    {
        [JsonPropertyName("slots")]
        public Slot[] Slots { get; set; }
    }
}
