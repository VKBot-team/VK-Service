using System.Threading.Tasks;

namespace VKApiCore
{
    public interface IVkService
    {
        Task SendMessageById(string userId, string message);
        Task<string[]> GetGroupUsers();
    }
}