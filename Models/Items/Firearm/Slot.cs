namespace Models.Items.Firearm
{
    internal sealed class Slot
    {
        /// <summary>
        /// A map of compatible item IDs categorized by kind
        /// </summary>
        public object filter { get; set; }
        /// <summary>
        /// Indicates whether the slot is required for an operational state
        /// </summary>
        public bool required { get; set; }
    }
}
