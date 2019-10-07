using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorks.HttpContext.BookStore.Responses
{
    public class SaleInfo
    {
        public string Country { get; set; }
        public string Saleability { get; set; }
        public bool IsEbook { get; set; }
    }
}
