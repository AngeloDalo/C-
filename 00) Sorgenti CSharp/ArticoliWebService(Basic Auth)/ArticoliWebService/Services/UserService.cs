using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Security;

namespace ArticoliWebService.Services
{
    public class UserService : IUserService
    {
        private AlphaShopDbContext alphaShopDbContext;

        public UserService(AlphaShopDbContext alphaShopDbContext)
        {
            this.alphaShopDbContext = alphaShopDbContext;
        }
        
        public async Task<bool> Authenticate(string username, string password)
        {
             bool retVal = false;

            PasswordHasher Hasher = new PasswordHasher();

            Utenti utente = await this.GetUser(username);

            if (utente != null)
            {
                string EncryptPwd = utente.Password;
                
                retVal = Hasher.Check(EncryptPwd, password).Verified;
            }
             
            return retVal; 
        }

        public async Task<Utenti> GetUser(string username)
        {
            return await this.alphaShopDbContext.Utenti
                .Include(r => r.Profili)
                .Where(c => c.UserId  == username)
                .FirstOrDefaultAsync();

        }
    }
}