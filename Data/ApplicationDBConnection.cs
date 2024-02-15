using Microsoft.EntityFrameworkCore;

namespace BookshopWeb.Data
{
  public class ApplicationDBConnection : DbContext
  {
    public ApplicationDBConnection(DbContextOptions<ApplicationDBConnection> options) : base(options)
    {

    }
  }
}
