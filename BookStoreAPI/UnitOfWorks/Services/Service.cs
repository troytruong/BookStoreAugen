using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorks.HttpContext.BookStore;
using UnitOfWorks.Services.BookStore;

namespace UnitOfWorks.Services
{
    public class Service : IService
    {
        public Service(BookStoreHttpContext bookStoreHttp)
        {
            BookStoreService = new BookStoreService(bookStoreHttp);
        }
        public IBookStoreService BookStoreService
        {
            get;
        }
    }
}
