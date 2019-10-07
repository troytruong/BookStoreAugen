using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks.HttpContext
{
    public abstract class HttpContextBase
    { 
        public abstract string GetHost();

        public virtual string CreateHostUrl(bool isSSL = false)
        {
            return $"{(isSSL ? "https" : "http")}://{GetHost()}/";
        }

        protected HttpContextBase()
        {
            var properties = GetType().GetProperties().Where(w => w.PropertyType.IsGenericType && w.PropertyType.GetGenericTypeDefinition() == typeof(RequestSet<>)).ToList();
            foreach(var property in properties)
            {
                property.SetValue(this, Activator.CreateInstance(property.PropertyType, this));
            }
            
        }
    }
}
