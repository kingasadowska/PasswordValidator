using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PasswordTestManager.Validators
{
    public class LengthValidator : Validator
    {
        private int Length { get; }

        public LengthValidator(int length)
        {
            Length = length;
        }

        public override Task<bool> ValidAsync(string password)
        {
            if (password.Length<=5)
            {
                Console.WriteLine("Ochrona 1");
            }
            else if (password.Length > 5 && password.Length < 8)
            {
                Console.WriteLine("Ochrona 2");
            }
            else
            {
                Console.WriteLine("ochrona 3");
            }
            if (string.IsNullOrWhiteSpace(password) || password.Length < Length)
            {
                return Task.FromResult(false);
            }

            return base.ValidAsync(password);

        }
    }
}
