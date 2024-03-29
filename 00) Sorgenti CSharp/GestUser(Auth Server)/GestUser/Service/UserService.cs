
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Models;
using Security;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly AlphaShopDbContext alphaShopDbContext;

        public UserService(AlphaShopDbContext alphaShopDbContext)
        {
            this.alphaShopDbContext = alphaShopDbContext;
        }

        public async Task<Utenti> GetUser(string UserId)
        {
           return await this.alphaShopDbContext.Utenti
                .Where(c => c.UserId  == UserId)
                .Include(r => r.Profili)
                //.Where(c => c.UserId  == username && c.Password == password)
                //.Where(c => c.Password == password) 
                .FirstOrDefaultAsync();
        }

        public Utenti CheckUser(string UserId)
        {
            return this.alphaShopDbContext.Utenti
                .AsNoTracking()
                .Where(c => c.UserId  == UserId)
                .FirstOrDefault();
        }

        public Utenti CheckUserByFid(string CodFid)
        {
            return this.alphaShopDbContext.Utenti
                .AsNoTracking()
                .Where(c => c.CodFidelity  == CodFid)
                .FirstOrDefault();
        }        

        public async Task<ICollection<Utenti>> GetAll()
        {
           return await this.alphaShopDbContext.Utenti
            .Include(r => r.Profili)
            .OrderBy(c => c.UserId)
            .ToListAsync();
        }
         
        public async Task<bool> Authenticate(string username, string password)
        {
            bool retVal = false;

            PasswordHasher Hasher = new PasswordHasher();

            Utenti utente = await this.alphaShopDbContext.Utenti
                .Include(r => r.Profili)
                .Where(c => c.UserId  == username)
                .FirstOrDefaultAsync();

            if (utente != null)
            {
                string EncryptPwd = utente.Password;
                
                retVal = Hasher.Check(EncryptPwd, password).Verified;
            }
             
            return retVal; 
        }

        public bool InsUtente(Utenti utente)
        {
            this.alphaShopDbContext.Add(utente);
            return Salva();
        }

        public bool UpdUtente(Utenti utente)
        {
            this.alphaShopDbContext.Update(utente);
            return Salva();
        }

        public bool DelUtente(Utenti utente)
        {
            this.alphaShopDbContext.Remove(utente);
            return Salva();
        }

        public bool Salva()
        {
            //this.alphaShopDbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Customers ON");
            var saved = this.alphaShopDbContext.SaveChanges();
            //this.alphaShopDbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Customers ON");
            return saved >= 0 ? true : false; 
        }

        
    }
}
