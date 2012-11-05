using System.Net;
using System.Net.Http;
using UltimateTeam.Toolkit.Service;

namespace UltimateTeam.Toolkit.Request
{
    public abstract class RequestBase
    {
        private IJsonDeserializer _jsonDeserializer;
        private static readonly CookieContainer CookieContainer = new CookieContainer();
        protected static string SessonId;
        protected readonly HttpClient Client;

        public IJsonDeserializer JsonDeserializer
        {
            get { return _jsonDeserializer ?? new JsonDeserializer(); }
            set { _jsonDeserializer = value; }
        }

        protected RequestBase()
        {
            var handler = new HttpClientHandler { CookieContainer = CookieContainer };
            Client = new HttpClient(handler);
        }
    }
}