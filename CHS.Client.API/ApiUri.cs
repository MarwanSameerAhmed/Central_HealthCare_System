using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API
{
    public enum RequestMethod
    {
        Get = 1,
        Post = 2
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiUri : Attribute
    {
        private string _Uri;
        public string Uri { 
            get
            {
                return "http://192.168.0.115:44332/api/" + _Uri;
            }
        }

        public RequestMethod Method { get; }

        public ApiUri(string uri, RequestMethod method = RequestMethod.Post)
        {
            _Uri = uri;
            Method = method;
        }
    }
}
