using System;
using System.Collections.Generic;

namespace Models.Items.Firearm
{
    internal sealed class Firearm
    {
        /// <summary>
        /// The type of the firearm, e.g. primary, secondary
        /// </summary>
        public string type {get; set; }
        /// <summary>
        /// The weapon class, e.g. assaultCarbine, pistol,  smg
        /// </summary>
        public string klass {get; set; }
        /// <summary>
        /// The weapon caliber
        /// </summary>
        public string caliber {get; set; }
        /// <summary>
        /// The rate of fire of the weapon
        /// </summary>
        public int rof {get; set; }
        /// <summary>
        /// Number of rounds per burst, if available
        /// </summary>
        public int burstRounds {get; set; }
        /// <summary>
        /// The action type e.g. gas, recoil, bolt
        /// </summary>
        public string action {get; set; }
        /// <summary>
        /// The fire modes of the weapon
        /// </summary>
        public string[] modes {get; set; }
        /// <summary>
        /// The muzzle velocity in meters per second
        /// </summary>
        public float velocity {get; set; }
        /// <summary>
        /// The maximum effective range of the weapon
        /// </summary>
        public float effectiveDist {get; set; }
        /// <summary>
        /// The base ergonomics of the firearm
        /// </summary>
        public float ergonomics {get; set; }
        /// <summary>
        /// Indicates if the butstock is fold or rectractable
        /// </summary>
        public bool foldRectractable {get; set; }
        /// <summary>
        /// The base vertical recoil of the weapon
        /// </summary>
        public float recoilVertical {get; set; }
        /// <summary>
        /// The base horizontal recoil of the weapon
        /// </summary>
        public float recoilHorizontal {get; set; }
        /// <summary>
        /// A map of the modification slots
        /// </summary>
        public object slots {get; set; }
    }
}
