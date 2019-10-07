using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStoreDb
{
    public abstract class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Column]
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
