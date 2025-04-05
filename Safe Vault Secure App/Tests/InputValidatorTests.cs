using Safe_Vault_Secure_App.Validators;
using Xunit;

namespace Safe_Vault_Secure_App.Tests
{
    public class InputValidatorTests
    {
        [Fact]
        public void ValidUsername_ReturnsTrue()
        {
            Assert.True(InputValidator.IsValidUsername("john_doe"));
        }

        [Fact]
        public void InvalidUsername_ReturnsFalse()
        {
            Assert.False(InputValidator.IsValidUsername("!!!bad$$$"));
        }

        [Fact]
        public void ValidEmail_ReturnsTrue()
        {
            Assert.True(InputValidator.IsValidEmail("user@example.com"));
        }

        [Fact]
        public void InvalidEmail_ReturnsFalse()
        {
            Assert.False(InputValidator.IsValidEmail("user@@example..com"));
        }
    }
}
