using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTestManager.Validators
{
    public class SpecialDigitValidator : Validator
    {
        public override Task<bool> ValidAsync(string password)
        {
            var isValidPasswordRegex = Regex.IsMatch(password, @"(?=.[!@#\$%\^&])");
            Console.WriteLine("zawiera znak specjalny");
            if (string.IsNullOrWhiteSpace(password) || !isValidPasswordRegex)
            {
                return Task.FromResult(false);
            }
            return base.ValidAsync(password);
        }
    }
}

