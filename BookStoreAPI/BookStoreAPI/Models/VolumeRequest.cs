using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    [DataContract]
    public class VolumeRequest
    {
        [DataMember]
        [Required]
        [MaxLength(100)]
        public string KeyWord { get; set; }
    }
}
