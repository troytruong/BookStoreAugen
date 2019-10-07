using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.BookStore.Repositories.DeliveryMethod
{
    public interface IDeliveryMethodRepository
    {
        Task<IList<BookStoreDb.DeliveryMethod>> GetDeliveryMethods();
    }
}
