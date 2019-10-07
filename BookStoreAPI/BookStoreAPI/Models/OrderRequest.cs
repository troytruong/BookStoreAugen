using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    [DataContract]
    public class OrderRequest
    {
        [DataMember]
        [Required]
        public DeliveryMethodRequest DeliveryMethod { get; set; }

        [DataMember]
        [Required]
        public Item Item { get; set; }

    }

    public class Item
    {
        public string Id { get; set; }
    }
}
