using Newtonsoft.Json;

namespace VKApiCore.JSONObjects
{
    public class Response
    {
        [JsonProperty("response")]
        public ResponseObject ResponseObject { get; set; }
    }
}