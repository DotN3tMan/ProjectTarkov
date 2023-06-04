using System.Text.Json.Serialization;

namespace Models.Items.Firearm
{
    public sealed class Firearm
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("weight")]
        public float Weight { get; set; }

        [JsonPropertyName("maxStack")]
        public int MaxStack { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("_modified")]
        public string Modified { get; set; }

        [JsonPropertyName("_kind")]
        public string Kind { get; set; }

        /// <summary>
        /// The type of the firearm, e.g. primary, secondary
        /// </summary>
        [JsonPropertyName("type")]
        public string Type {get; set; }

        /// <summary>
        /// The weapon class, e.g. assaultCarbine, pistol,  smg
        /// </summary>
        [JsonPropertyName("class")]
        public string Class {get; set; }

        /// <summary>
        /// The weapon caliber
        /// </summary>
        [JsonPropertyName("caliber")]
        public string Caliber {get; set; }

        /// <summary>
        /// The rate of fire of the weapon
        /// </summary>
        [JsonPropertyName("rof")]
        public int Rof {get; set; }

        /// <summary>
        /// Number of rounds per burst, if available
        /// </summary>
        [JsonPropertyName("burstRounds")]
        public int BurstRounds {get; set; }

        /// <summary>
        /// The action type e.g. gas, recoil, bolt
        /// </summary>
        [JsonPropertyName("action")]
        public string Action {get; set; }

        /// <summary>
        /// The fire modes of the weapon
        /// </summary>
        [JsonPropertyName("modes")]
        public string[] Modes {get; set; }

        /// <summary>
        /// The muzzle velocity in meters per second
        /// </summary>
        [JsonPropertyName("velocity")]
        public float Velocity {get; set; }

        /// <summary>
        /// The maximum effective range of the weapon
        /// </summary>
        [JsonPropertyName("effectiveDist")]
        public float EffectiveDist {get; set; }

        /// <summary>
        /// The base ergonomics of the firearm
        /// </summary>
        [JsonPropertyName("ergonomics")]
        public float Ergonomics {get; set; }

        /// <summary>
        /// Indicates if the butstock is fold or rectractable
        /// </summary>
        [JsonPropertyName("foldRectractable")]
        public bool FoldRectractable {get; set; }

        /// <summary>
        /// The base vertical recoil of the weapon
        /// </summary>
        [JsonPropertyName("recoilVertical")]
        public float RecoilVertical {get; set; }

        /// <summary>
        /// The base horizontal recoil of the weapon
        /// </summary>
        [JsonPropertyName("recoilHorizontal")]
        public float RecoilHorizontal {get; set; }

        /// <summary>
        /// A map of the modification slots
        /// </summary>
        [JsonPropertyName("slots")]
        public Dictionary<string, Slot> Slots {get; set; }
    }
}
