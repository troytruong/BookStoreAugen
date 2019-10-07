using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorks.HttpContext
{
    public class ResponseGet<TResponse> where TResponse :  IResponse
    {
        public string Message { get; set; }

        public string Code { get; set; }

        public TResponse Data { get; set; }

    }
}
