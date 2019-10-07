using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorks.HttpContext.BookStore.Responses
{
    public class VolumeResponse : IResponse
    {
        public string Kind { get; set; }

        public int TotalItems { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
