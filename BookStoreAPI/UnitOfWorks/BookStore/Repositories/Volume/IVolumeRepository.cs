using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorks.HttpContext.BookStore.Requests;
using UnitOfWorks.HttpContext.BookStore.Responses;

namespace UnitOfWorks.BookStore.Repositories.Volume
{
    public interface IVolumeRepository
    {
        Task<VolumeResponse> SearchAsync(VolumeRequest request);
    }
}
