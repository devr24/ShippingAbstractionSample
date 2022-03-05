namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.ReceiverReferences
    /// </summary>
    public class ReceiverReferences
    {
        /// <summary>
        /// Receiver reference 1.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string ReceiverReference1 { get; set; }

        /// <summary>
        /// Receiver reference 2.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string ReceiverReference2 { get; set; }

        /// <summary>
        /// Receiver reference 3.
        /// For example order number can be sent here This information will only be provided to the carrier
        /// if it's additional fields for such information exists for the carrier.
        /// In most cases not communicated or printed on label.
        /// </summary>
        public string ReceiverReference3 { get; set; }
    }
}
