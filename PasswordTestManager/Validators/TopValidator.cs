using System;
using System.IO;
using System.Threading.Tasks;

namespace PasswordTestManager.Validators
{

    public class TopValidator : Validator
    {
        public override async Task<bool> ValidAsync(string password)
        {
            const string fileContent = "CommonPasswords.txt";

            using (var sourceStream = File.Open(fileContent, FileMode.Open))
            {
                var result = new byte[sourceStream.Length];
                await sourceStream.ReadAsync(result, 0, (int) sourceStream.Length);
                var words = result.ToString();
                var isTopWord = words.Contains(password);
                Console.WriteLine("zawiera slowo z top listy");

                if (string.IsNullOrWhiteSpace(password) || !isTopWord)
                {
                    return await Task.FromResult(false);
                }
            }

            return await base.ValidAsync(password);
        }
    }
}
