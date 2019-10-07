using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Models;
using BookStoreDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorks.BookStore;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public OrderController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<OrderResponse> Post(OrderRequest order)
        {
            var result = await unitOfWork.OrderRepository.AddAsync(new Order { 
                DeliveryMethodId = order.DeliveryMethod.Id,
                OrderNumber = order.Item.Id + order.DeliveryMethod.Id + DateTime.UtcNow.Ticks,
                OrderDetails = new List<OrderDetail> { 
                    new OrderDetail { 
                        ItemId = order.Item.Id
                    } 
                },
                DeliveryMethodCost = order.DeliveryMethod.Cost
            });
            await unitOfWork.CommitAsync();
            return new OrderResponse { 
                DeliveryMethod = order.DeliveryMethod,
                OrderNumber = result.OrderNumber,
                Id = result.Id,
                Item = order.Item
            };
        }
    }
}