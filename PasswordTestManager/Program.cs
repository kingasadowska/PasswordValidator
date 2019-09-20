using System;
using PasswordTestManager.Levels;

namespace PasswordTestManager
{
    public static class Program
    {
        private static void Main()
        {
            while (true)
            {
                //var password = "123456";
                Console.WriteLine("Write password");
                var password = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(password))
                {
                    var passwordTester = new PasswordTester(new LevelThree());
                    Console.WriteLine(passwordTester.Validate(password));

                    passwordTester = new PasswordTester(new LevelTwo());
                    Console.WriteLine(passwordTester.Validate(password));

                    passwordTester = new PasswordTester(new LevelOne());
                    Console.WriteLine(passwordTester.Validate(password));

                    Console.ReadKey();
                }

            }
        }
    }
}
