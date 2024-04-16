using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 

public class AccountContext : IdentityDbContext<IdentityUser>
{
    public AccountContext(DbContextOptions<AccountContext> options) 
    : base(options)
    {
        Console.WriteLine("AccountContext created");
        Database.EnsureCreated();
    }
}