using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebApplicationApi.Model;

namespace WebApplicationApi.Data
{
    public class Context:IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
    }
}
