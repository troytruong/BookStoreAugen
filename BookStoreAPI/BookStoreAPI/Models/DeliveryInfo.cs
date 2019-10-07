using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    [DataContract]
    public class DeliveryInfo
    {
        [MaxLength(100)]
        [DataMember]
        [Required]
        public string FullName { get; set; }

        [MaxLength(200)]
        [DataMember]
        [Required]
        public string Address { get; set; }

        [MaxLength(50)]
        [DataMember]
        [Required]
        public string City { get; set; }
    }
}
