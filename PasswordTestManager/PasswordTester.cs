using System.Threading.Tasks;
using PasswordTestManager.Levels;

namespace PasswordTestManager
{
    public class PasswordTester
    {
        private readonly ILevel _level;

        public PasswordTester(ILevel level)
        {
            _level = level;
        }

        public Task<bool> Validate(string password)
        {
            return _level.ValidatePasswordAsync(password);
        }
    }
}
