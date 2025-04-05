using System.Text.RegularExpressions;

namespace Safe_Vault_Secure_App.Validators
{
    public class InputValidator
    {
        public static bool IsValidUsername(string input) =>
        Regex.IsMatch(input, "^[a-zA-Z0-9_.-]{3,20}$");

        public static bool IsValidEmail(string email) =>
            Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
