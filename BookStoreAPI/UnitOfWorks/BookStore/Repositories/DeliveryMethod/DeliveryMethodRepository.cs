using BookStoreDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.BookStore.Repositories.DeliveryMethod
{
    public class DeliveryMethodRepository : IDeliveryMethodRepository
    {
        private readonly DbSet<BookStoreDb.DeliveryMethod> deliveryMethods;
        public DeliveryMethodRepository(DbSet<BookStoreDb.DeliveryMethod> deliveryMethods)
        {
            this.deliveryMethods = deliveryMethods;
        }

        public async Task<IList<BookStoreDb.DeliveryMethod>> GetDeliveryMethods()
        {
            return await deliveryMethods.ToListAsync();
        }
    }
}
