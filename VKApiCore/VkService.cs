using System;
using System.Collections.Generic;
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
                { "user_id", userId },
                { "message", message }
            });
        }

        public async Task SendMessagesByIds(string[] userIds, string message)
        {
            if (userIds.Length > 100)
                throw new ArgumentException("Users should be less or equal than 100");

            await VkApi.ExecMethod(Method.MessageSend, new Dictionary<string, string>
            {
                { "user_ids", string.Join(',', userIds) },
                { "message", message }
            });
        }

        public async Task SendGifById(string userId, string gifLink)
        {
            await VkApi.ExecMethod(Method.MessageSend, new Dictionary<string, string>
            {
                { "user_id", userId },
                { "attachment", gifLink }
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