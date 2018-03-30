using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class User : IdentityUser<int>
{
    public string Name { get; set; }
    public string Password { get; set; }
}