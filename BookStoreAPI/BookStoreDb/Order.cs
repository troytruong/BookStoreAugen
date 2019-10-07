using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStoreDb
{
    [Table(nameof(Order))]
    public class Order : BaseModel
    {
        [Column]
        public string OrderNumber { get; set; }

        [Column]
        public long DeliveryMethodId { get; set; }

        [ForeignKey(nameof(DeliveryMethodId))]
        public DeliveryMethod DeliveryMethod { get; set; }

        [Column]
        public float DeliveryMethodCost { get; set; }

        [Column]
        public long? FromDeliveryInfoId { get; set; }

        [ForeignKey(nameof(FromDeliveryInfoId))]
        public FromDeliveryInfo? FromDeliveryInfo { get; set; }

        [Column]
        public long? ToDeliveryInfoId { get; set; }

        [ForeignKey(nameof(ToDeliveryInfoId))]
        public ToDeliveryInfo? ToDeliveryInfo { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
