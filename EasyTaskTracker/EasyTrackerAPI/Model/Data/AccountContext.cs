using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 

public class AccountContext : IdentityDbContext<User>
{
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
    }
}