using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordTestManager.Validators
{
    public class NumberInTheMiddleValidator : Validator
    {
        public override Task<bool> ValidAsync(string password)
        {
            var isValidPasswordRegexDigit = Regex.IsMatch(password, @"([a-z]+\d{1}[a-z]+)");
            Console.WriteLine("ma liczbe w srodku");
            if (string.IsNullOrWhiteSpace(password) || !isValidPasswordRegexDigit)
            {
                return Task.FromResult(false);
            }

            return base.ValidAsync(password);
        }
    }
}
