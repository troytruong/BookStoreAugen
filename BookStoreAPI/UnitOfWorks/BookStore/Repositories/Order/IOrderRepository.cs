using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.BookStore.Repositories.Order
{
    public interface IOrderRepository
    {
        Task<BookStoreDb.Order> AddAsync(BookStoreDb.Order order);
    }
}
