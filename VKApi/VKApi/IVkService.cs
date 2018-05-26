using System.Threading.Tasks;

namespace VKApi
{
    public interface IVkService
    {
        Task SendMessageById(string userId, string message);
    }
}
