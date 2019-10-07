using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorks.HttpContext.BookStore;
using UnitOfWorks.HttpContext.BookStore.Requests;
using UnitOfWorks.HttpContext.BookStore.Responses;

namespace UnitOfWorks.Services.BookStore
{
    public class BookStoreService : IBookStoreService
    {
        private BookStoreHttpContext bookStoreHttp;
        public BookStoreService (BookStoreHttpContext bookStoreHttp)
        {
            this.bookStoreHttp = bookStoreHttp;
        }
        public async Task<VolumeResponse> SearchAsync (VolumeRequest data)
        {
            bookStoreHttp.Volumes.Data = data;
            var response = await bookStoreHttp.Volumes.GetAsync<VolumeResponse>();
            return response.Data;
        }
    }
}
