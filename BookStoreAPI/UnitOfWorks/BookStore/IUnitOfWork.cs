using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitOfWorks.BookStore.Repositories.DeliveryMethod;
using UnitOfWorks.BookStore.Repositories.Order;
using UnitOfWorks.BookStore.Repositories.Volume;

namespace UnitOfWorks.BookStore
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }

        IVolumeRepository VolumeRepository { get; }

        IDeliveryMethodRepository DeliveryMethodRepository { get; }

        Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
