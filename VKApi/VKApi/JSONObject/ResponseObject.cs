using Newtonsoft.Json;

namespace VKApi.JSONObject
{
    public class ResponseObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}