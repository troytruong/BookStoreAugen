using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UnitOfWorks.HttpContext.BookStore.Requests
{
    [DataContract(Name = "volumes")] 
    public class VolumeRequest : IRequest
    {
        [JsonProperty(PropertyName = "q")]
        public string KeyWord { get; set; }
    }
}
