using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using UltimateTeam.Toolkit.Service;

namespace UltimateTeam.Toolkit.Request
{
    public abstract class RequestBase
    {
        private IJsonDeserializer _jsonDeserializer;
        protected readonly HttpClient Client;
        protected static readonly CookieContainer CookieContainer = new CookieContainer();
        protected static Dictionary<string, string> CustomHeaders = new Dictionary<string, string>();

        public IJsonDeserializer JsonDeserializer
        {
            get { return _jsonDeserializer ?? new JsonDeserializer(); }
            set { _jsonDeserializer = value; }
        }

        protected RequestBase()
        {
            //var cookies = CookieContainer.GetCookies(new Uri("http://www.ea.com"));
            //foreach (Cookie cookie in cookies)
            //{
            //    cookie.Domain = ".ea.com";
            //}
            var handler = new HttpClientHandler { CookieContainer = CookieContainer };
            Client = new HttpClient(handler);
        }
    }
}