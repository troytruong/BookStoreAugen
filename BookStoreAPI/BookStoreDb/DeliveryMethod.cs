using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStoreDb
{
    [Table(nameof(DeliveryMethod))]
    public class DeliveryMethod : BaseModel
    {
        [Column]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column]
        public float BaseCost { get; set; }

        [Column(Order = 1)]
        public float January { get; set; } = 1;

        [Column(Order = 2)]
        public float February { get; set; } = 1;

        [Column(Order = 3)]
        public float March { get; set; } = 1;

        [Column(Order = 4)]
        public float April { get; set; } = 1;

        [Column(Order = 5)]
        public float May { get; set; } = 1;

        [Column(Order = 6)]
        public float June { get; set; } = 1;

        [Column(Order = 7)]
        public float July { get; set; } = 1;

        [Column(Order = 8)]
        public float August { get; set; } = 1;

        [Column(Order = 9)]
        public float September { get; set; } = 1;

        [Column(Order = 10)]
        public float October { get; set; } = 1;

        [Column(Order = 11)]
        public float November { get; set; } = 1;

        [Column(Order = 12)]
        public float December { get; set; } = 1;

        public ICollection<Order> Orders { get; set; }
    }
}
