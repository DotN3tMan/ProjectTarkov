using System.Text.Json.Serialization;

namespace Models.Items.Firearm
{
    public sealed class GridModifier
    {
        /// <summary>
        /// The grid height modifier
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }
        /// <summary>
        /// The grid width modifier
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }
    }
}
