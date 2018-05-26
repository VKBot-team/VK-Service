using System.Collections.Generic;
using System.Threading.Tasks;

namespace VKApi
{
    public class VkService : IVkService
    {
        public async Task SendMessageById(string userId, string message)
        {
            await VkApi.ExecMethod(Method.MessageSend, new Dictionary<string, string>
            {
                {"user_id", userId},
                {"message", message}
            });
        }
    }
}