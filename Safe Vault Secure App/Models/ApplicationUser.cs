using Microsoft.AspNetCore.Identity;

namespace Safe_Vault_Secure_App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Department { get; set; }
    }
}
