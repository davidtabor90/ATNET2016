﻿using System;
using System.Runtime.Serialization;

namespace SharedLibs.DataContracts
{
    [DataContract]
    public class Basket : DTO
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
    }
}
