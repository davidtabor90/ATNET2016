using System;
using System.Runtime.Serialization;

namespace SharedLibs.DataContracts
{
    [DataContract]
    public class BasketItem : DTO
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
    }
}
