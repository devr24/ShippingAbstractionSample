namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.SenderReferences
    /// </summary>
    public class SenderReferences
    {
        /// <summary>
        /// Sender reference 1.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string SenderReference1 { get; set; }

        /// <summary>
        /// Sender reference 2.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string SenderReference2 { get; set; }

        /// <summary>
        /// Sender reference 3.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string SenderReference3 { get; set; }
    }
}