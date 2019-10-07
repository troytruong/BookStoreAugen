using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitOfWorks.BookStore.Repositories.DeliveryMethod;
using UnitOfWorks.BookStore.Repositories.Order;
using UnitOfWorks.BookStore.Repositories.Volume;
using UnitOfWorks.Services;

namespace UnitOfWorks.BookStore
{
    public class BookStoreUnitOfWork : IUnitOfWork
    {
        private readonly BookStoreDb.BookStoreContext context;
        public BookStoreUnitOfWork(BookStoreDb.BookStoreContext context, IService service)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            this.context = context;
            OrderRepository = new OrderRepository(context.Orders);
            DeliveryMethodRepository = new DeliveryMethodRepository(context.DeliveryMethods);
            VolumeRepository = new VolumeRepository(service.BookStoreService);
        }

        public IOrderRepository OrderRepository
        {
            get;
        }

        public IVolumeRepository VolumeRepository
        {
            get;
        }

        public IDeliveryMethodRepository DeliveryMethodRepository
        {
            get;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
