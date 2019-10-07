using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorks.HttpContext.BookStore.Requests;

namespace UnitOfWorks.HttpContext.BookStore
{
    public class BookStoreHttpContext : HttpContextBase
    {
        public BookStoreHttpContext() : base()
        {
        }

        public override string GetHost()
        {
            return "www.googleapis.com/books/v1";
        }

        public RequestSet<VolumeRequest> Volumes { get; set; }
    }
}
