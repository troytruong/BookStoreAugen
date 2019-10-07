using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStoreDb
{
    [Table(nameof(OrderDetail))]
    public class OrderDetail: BaseModel
    {
        [Column(nameof(OrderId))]
        public long OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        [Column]
        public string ItemId { get; set; }

    }
}
