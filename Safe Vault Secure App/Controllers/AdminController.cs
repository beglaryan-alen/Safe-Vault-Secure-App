using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Safe_Vault_Secure_App.Entities;
using Safe_Vault_Secure_App.Validators;

namespace Safe_Vault_Secure_App.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult SecureArea()
        {
            var logs = _context.SecureLogs.OrderByDescending(l => l.Timestamp).ToList();
            return View(logs);
        }

        [HttpPost]
        public IActionResult LogAction(string action)
        {
            if (!InputValidator.IsValidUsername(action))
            {
                ModelState.AddModelError("Action", "Invalid input.");
                return RedirectToAction("SecureArea");
            }

            _context.SecureLogs.Add(new SecureLog
            {
                Action = action,
                PerformedBy = User.Identity.Name,
                Timestamp = DateTime.UtcNow
            });
            _context.SaveChanges();
            return RedirectToAction("SecureArea");
        }
    }
}
