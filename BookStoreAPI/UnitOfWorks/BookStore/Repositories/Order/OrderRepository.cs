using BookStoreDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.BookStore.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbSet<BookStoreDb.Order> orders;
        public OrderRepository(DbSet<BookStoreDb.Order> orders)
        {
            this.orders = orders;
        }

        public async Task<BookStoreDb.Order> AddAsync(BookStoreDb.Order order)
        {
            var result = await orders.AddAsync(order);
            return result.Entity;
        }
    }
}
