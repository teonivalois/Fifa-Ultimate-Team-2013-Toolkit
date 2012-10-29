using System;
using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Model;

namespace UltimateTeam.Toolkit.Request
{
    public class SearchRequest : RequestBase
    {
        private const uint PageSize = 12;

        public async Task<SearchResponse> SearchAsync(SearchParameters parameters)
        {
            var searchUri = BuildUriString(parameters);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, searchUri)
            {
                Content = new StringContent(" ")
            };

            CustomHeaders.Add("x-http-method-override", "GET");

            foreach (var customHeader in CustomHeaders)
            {
                requestMessage.Headers.TryAddWithoutValidation(customHeader.Key, customHeader.Value);
            }

            var response = await Client.SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();

            var searchResponse = JsonDeserializer.Deserialize<SearchResponse>(await response.Content.ReadAsStreamAsync());

            return searchResponse;
        }

        private static Uri BuildUriString(SearchParameters parameters)
        {
            var uriString = string.Format("https://utas.s2.fut.ea.com/ut/game/fifa13/auctionhouse?start={0}&num={1}",
                (parameters.Page - 1) * PageSize, PageSize + 1);

            if (parameters.League > 0)
                uriString += "&leag=" + parameters.League;

            SetLevel(parameters.Level, ref uriString);

            if (parameters.Nation > 0)
                uriString += "&nat=" + parameters.Nation;

            if (!string.IsNullOrEmpty(parameters.Formation))
                uriString += "&form=" + parameters.Formation;

            if (parameters.Team > 0)
                uriString += "&team=" + parameters.Team;

            if (!string.IsNullOrEmpty(parameters.Position))
                uriString += "&pos=" + parameters.Position;

            if (!string.IsNullOrEmpty(parameters.Type))
                uriString += "&type=" + parameters.Type;

            return new Uri(uriString);
        }

        private static void SetLevel(Level level, ref string uriString)
        {
            switch (level)
            {
                case Level.All:
                    break;
                case Level.Bronze:
                case Level.Silver:
                case Level.Gold:
                    uriString += "&lev=" + level;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("level");
            }
        }
    }
}