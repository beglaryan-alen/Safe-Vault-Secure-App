using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Safe_Vault_Secure_App.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<SecureLog> SecureLogs { get; set; }
    }
}
