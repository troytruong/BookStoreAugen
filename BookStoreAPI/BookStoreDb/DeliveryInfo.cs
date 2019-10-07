using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStoreDb
{
    [Table(nameof(ToDeliveryInfo))]
    public class ToDeliveryInfo : BaseModel
    {
        [Column]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Column]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column]
        [MaxLength(50)]
        public string City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    [Table(nameof(FromDeliveryInfo))]
    public class FromDeliveryInfo : BaseModel
    {
        [Column]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Column]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column]
        [MaxLength(50)]
        public string City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
