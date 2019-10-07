using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorks.HttpContext.BookStore;
using UnitOfWorks.Services.BookStore;

namespace UnitOfWorks.Services
{
    public interface IService
    {
        IBookStoreService BookStoreService { get; }
    }
}
