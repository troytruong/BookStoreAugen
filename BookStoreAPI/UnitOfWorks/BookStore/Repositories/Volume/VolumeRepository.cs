using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorks.HttpContext.BookStore.Requests;
using UnitOfWorks.HttpContext.BookStore.Responses;
using UnitOfWorks.Services;
using UnitOfWorks.Services.BookStore;

namespace UnitOfWorks.BookStore.Repositories.Volume
{
    public class VolumeRepository : IVolumeRepository
    {
        private readonly IBookStoreService service;
        public VolumeRepository(IBookStoreService service)
        {
            this.service = service;
        }

        public async Task<VolumeResponse> SearchAsync(VolumeRequest request)
        {
            return await service.SearchAsync(request);
        }
    }
}
