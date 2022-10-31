using System;
using System.Text.RegularExpressions;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = PasswordLengthCheck(password);
            bool isPasswordContainValidSymbols = PasswordLettersAndDigitsCheck(password);
            bool isDigitInPasswordLeastTwo = PasswordTwoDigitCheck(password);

            if (isPasswordLengthValid && isPasswordContainValidSymbols && isDigitInPasswordLeastTwo)
            {
                Console.WriteLine($"Password is valid");
            }

            if (!isPasswordLengthValid)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");

            }

            if (!isPasswordContainValidSymbols)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            if (!isDigitInPasswordLeastTwo)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }
        }
        

        private static bool PasswordLengthCheck(string password)
        {

            return password.Length >= 6 && password.Length <= 10;
        }

        private static bool PasswordLettersAndDigitsCheck(string password)
        {

            foreach (var character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool PasswordTwoDigitCheck(string password)
        {
            int count = 0;
            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            return count >= 2;
        }
    }
}
