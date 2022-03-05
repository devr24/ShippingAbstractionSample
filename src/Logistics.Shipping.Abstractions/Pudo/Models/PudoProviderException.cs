using System.Net;
using System.Runtime.Serialization;

namespace Logistics.Shipping.Abstractions.Pudo.Models
{
    [Serializable]
    public class PudoProviderException : Exception
    {
        public string Provider { get; }
        public HttpStatusCode ProviderHttpResponseCode { get; }
        public string ProviderResponseBody { get; }

        public PudoProviderException(string message, Exception inner, string provider, HttpStatusCode providerHttpResponseCode, string providerResponseBody)
            : base(message, inner)
        {
            Provider = provider;
            ProviderHttpResponseCode = providerHttpResponseCode;
            ProviderResponseBody = providerResponseBody;
        }

        protected PudoProviderException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
