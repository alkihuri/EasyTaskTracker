
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

public class User  : IdentityUser
{ 

    public User(string name)
    {
        Name = name; 
    }

    public User()
    {
        
    }

    [Key]
    public long Id  { get; set; }
    public string? Name { get; set; } 
    public string? Password { get; set; }       
    public string? Email { get; set; }
}
 