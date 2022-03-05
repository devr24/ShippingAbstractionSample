namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.Attribute
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Name of the attribute. Both Code and Value are required if attributes are used
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the attribute. Both Code and Value are required if attributes are used
        /// </summary>
        public string Value { get; set; }
    }
}