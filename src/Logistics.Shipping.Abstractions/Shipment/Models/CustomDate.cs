using System;

namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.CustomDate
    /// </summary>
    public class CustomDate
    {
        /// <summary>
        /// Code describing what the date is for. Mandatory if Value is sent in
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Date connected to code. Mandatory if Code is sent in. Date ISO 8601
        /// </summary>
        public DateTime Value { get; set; }
    }
}
