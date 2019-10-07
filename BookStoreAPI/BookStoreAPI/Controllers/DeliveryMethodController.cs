using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorks.BookStore;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryMethodController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public DeliveryMethodController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IList<DeliveryMethodResponse>> Get()
        {
            var methods = await unitOfWork.DeliveryMethodRepository.GetDeliveryMethods();
            return methods.Select(s => {
                var item = new DeliveryMethodResponse
                {
                    Name = s.Name,
                    Id = s.Id
                };
                item.Cost = item.CalculateCost(s);
                return item;
            }).ToList();
        }


    }
}