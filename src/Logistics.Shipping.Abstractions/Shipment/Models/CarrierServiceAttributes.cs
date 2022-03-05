namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.CarrierServiceAttributes
    ///
    /// Optional services that can typically be applied for multiple different carrier services,
    /// such as saturday delivery or refrigerated
    /// </summary>
    public class CarrierServiceAttributes
    {
        public class NamedValue
        {
            /// <summary>
            /// Code describing the value
            /// </summary>
            public string Name { get; set; }

            public string Value { get; set; }
        }

        /// <summary>
        /// Code identifying the optional service
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Values for an optional services, for example value and currency for an insurance service.
        /// </summary>
        public IReadOnlyList<NamedValue> CarrierServiceAttributeValues { get; set; }
    }
}
