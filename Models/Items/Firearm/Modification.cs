using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Models.Items.Firearm
{
    public sealed class Modification
    {
        [JsonPropertyName("_id")]
        public string id { get; set; }

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
        /// The ergonomics modifier of the modification
        /// </summary>
        [JsonPropertyName("ergonomics")]
        public int Ergonomics {get; set;}

        /// <summary>
        /// Indicates if the modification is moddable in Raid. 0 = no, 1 = yes, 2 = only with a tool
        /// </summary>
        [JsonPropertyName("raidModdable")]
        public int RaidModdable {get; set;}

        /// <summary>
        /// The modifiers that influence the grid properties of the parent
        /// </summary>
        [JsonPropertyName("gridModifier")]
        public GridModifier GridModifier {get; set;}

        /// <summary>
        /// A map of the modification slots
        /// </summary>
        [JsonPropertyName("slots")]
        public Dictionary<string, Slot> Slots {get; set;}

        /// <summary>
        /// A map of compatible item IDs (reverse) categorized by kind
        /// </summary>
        [JsonPropertyName("compatibility")]
        public Dictionary<string, string[]> Compatibility {get; set;}

        /// <summary>
        /// A map of item IDs to conflict with, categorized by kind
        /// </summary>
        [JsonPropertyName("conflicts")]
        public object Conflicts {get; set;}
    }
}
