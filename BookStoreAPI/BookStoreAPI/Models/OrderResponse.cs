using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    [DataContract]
    public class OrderResponse : OrderRequest
    {
        [DataMember]
        [Required]
        public long Id { get; set; }

        [DataMember]
        [Required]
        public string OrderNumber { get; set; }
    }
}
