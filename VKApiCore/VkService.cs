using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VKApiCore.JSONObjects;

namespace VKApiCore
{
    public class VkService: IVkService
    {
        public async Task SendMessageById(string userId, string message)
        {
            await VkApi.ExecMethod(Method.MessageSend, new Dictionary<string, string>
            {
                {"user_id", userId},
                {"message", message}
            });
        }

        public async Task<string[]> GetGroupUsers()
        {
            var result = await VkApi.ExecMethod(Method.GetMembers, new Dictionary<string, string>
            {
                { "group_id", Settings.GroupId }
            });

            var jsonData = JsonConvert.DeserializeObject<Response>(result);
            return jsonData.ResponseObject.Items.Select(x => x.ToString()).ToArray();
        }
    }
}