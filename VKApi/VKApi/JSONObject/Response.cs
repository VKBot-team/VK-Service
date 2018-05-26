using Newtonsoft.Json;

namespace VKApi.JSONObject
{
    public class Response
    {
        [JsonProperty("response")]
        public ResponseObject ResponseObject { get; set; }
    }
}