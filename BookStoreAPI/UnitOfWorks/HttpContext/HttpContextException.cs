using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UnitOfWorks.HttpContext
{
    public class HttpContextException : Exception
    {
        public HttpResponseMessage ResponseMessage { get; set; }

    }
}
