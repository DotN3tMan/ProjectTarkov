using System.Text.Json.Serialization;

namespace Models.TarkovGraphQlModels
{
    public sealed class WeaponItems
    {
        [JsonPropertyName("items")]
        public Weapon[] List { get; set; }
    }
}
