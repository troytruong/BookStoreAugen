using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    [DataContract]
    public class DeliveryMethodRequest
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public float Cost { get; set; }
    }
}
