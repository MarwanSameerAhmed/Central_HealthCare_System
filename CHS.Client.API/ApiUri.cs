using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiUri : Attribute
    {
        public string Uri { get; }

        public ApiUri(string uri)
        {
            Uri = uri;
        }

        public static string GetApiUri<T>()
        {
            ApiUri attribute = (ApiUri)Attribute.GetCustomAttribute(typeof(T), typeof(ApiUri));
            return attribute?.Uri;
        }
    }
}
