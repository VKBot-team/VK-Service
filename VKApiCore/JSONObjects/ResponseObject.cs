using Newtonsoft.Json;

namespace VKApiCore.JSONObjects
{
    public class ResponseObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}