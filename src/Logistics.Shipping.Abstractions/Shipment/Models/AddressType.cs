namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    public enum AddressType
    {
        /// <summary>
        /// Party which sends goods or is legally responsible for the shipment
        /// </summary>
        Sender = 0,

        /// <summary>
        /// Delivery Part
        /// </summary>
        Receiver = 1,

        /// <summary>
        /// Alternative return address (for unclaimed returns)
        /// </summary>
        ReturnTo = 2,

        /// <summary>
        /// Alternative return address (for unclaimed returns)
        /// </summary>
        ReturnCenter = 3,

        /// <summary>
        /// Party where goods are collected or taken over by the carrier (i.e. if other than SENDER)
        /// </summary>
        Pickup = 4,

        /// <summary>
        /// Delivery point for B2C services
        /// </summary>
        CollectionPoint = 5,

        /// <summary>
        /// Legal part if other than RECEIVER
        /// </summary>
        Buyer = 6,

        /// <summary>
        /// Importer address
        /// </summary>
        Importer = 7,

        /// <summary>
        /// Party which is working on behalf of another party
        /// </summary>
        Broker = 8,

        /// <summary>
        /// Exporter address
        /// </summary>
        Exporter = 9,

        /// <summary>
        /// Transport payer address when transport payer is other than default
        /// </summary>
        TransportPayer = 10,

        /// <summary>
        /// Tax and Duties payer address when tax and duties payer is other than default
        /// </summary>
        TaxAndDutiesPayer = 11
    }
}