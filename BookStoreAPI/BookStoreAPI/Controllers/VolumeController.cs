using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorks.BookStore;
using UnitOfWorks.HttpContext.BookStore.Responses;
using UnitOfWorks.Services;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolumeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public VolumeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("{keyword}")]
        public async Task<VolumeResponse> Get(string keyword)
        {
            return await unitOfWork.VolumeRepository.SearchAsync(new UnitOfWorks.HttpContext.BookStore.Requests.VolumeRequest { 
                KeyWord = keyword
            });
        }
    }
}