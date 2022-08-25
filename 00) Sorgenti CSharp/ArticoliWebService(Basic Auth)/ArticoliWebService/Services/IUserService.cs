using System.Threading.Tasks;
using Models;

namespace ArticoliWebService.Services
{
    public interface IUserService
    {
        Task<bool> Authenticate(string username, string password);

        Task<Utenti> GetUser(string username);
    }
}