using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class WeaponDb
    {
        [JsonPropertyName("data")]
        public WeaponItems Root { get; set; }
    }
}
