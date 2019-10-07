using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorks.HttpContext;
using UnitOfWorks.HttpContext.BookStore.Requests;
using UnitOfWorks.HttpContext.BookStore.Responses;

namespace UnitOfWorks.Services.BookStore
{
    public interface IBookStoreService
    {
        Task<VolumeResponse> SearchAsync (VolumeRequest data);
    }
}
