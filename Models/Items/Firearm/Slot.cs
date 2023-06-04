using System.Text.Json.Serialization;

namespace Models.Items.Firearm
{
    public sealed class Slot
    {
        /// <summary>
        /// A map of compatible item IDs categorized by kind
        /// </summary>
        [JsonPropertyName("filter")]
        public Dictionary<string, string[]> Filter { get; set; }
        /// <summary>
        /// Indicates whether the slot is required for an operational state
        /// </summary>
        [JsonPropertyName("required")]
        public bool Required { get; set; }
    }
}
