using Microsoft.EntityFrameworkCore;
using Services;

namespace PriceWebService.test
{
    public class DbContextMocker
    {
        public static AlphaShopDbContext alphaShopDbContext()
        {
        var connectionString =  "Data Source=localhost;Initial Catalog=AlphaShop;Integrated Security=False;User ID=sa;Password=123Stella";

            // Create options for DbContext instance
        var options = new DbContextOptionsBuilder<AlphaShopDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        // Create instance of DbContext
        var dbContext = new AlphaShopDbContext(options);

        return dbContext;
        }
    }
}