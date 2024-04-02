

using System.Security.Cryptography.X509Certificates;

public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public  static User CurrentUser;    

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(User account)
    {
        Console.WriteLine("[Account manager] Creating account: " + account.Name);

        if(_context.Users.Any(u => u.Name == account.Name))
        {
            Console.WriteLine("Account with name " + account.Name + " already exists."); 
        }

        account.ID = _context.Users.Count() + 1;    
        _context.Users.Add(account); 
        _context.SaveChanges();
    }

    public User GetAccount(string accountName) 
    {
       return _context.Users.FirstOrDefault(u => u.Name == accountName);
    }

    public List<User> GetAccounts()
    {
        return _context.Users.ToList(); 
    }

    public bool VerifyAccount(User account)
    {
        if(_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
        {
            CurrentUser = account;
            Console.WriteLine("Account verified.");
            return true;    
        }
        else 
        {
            Console.WriteLine("Account not verified.");
            return false; 
        }    
    }
}   