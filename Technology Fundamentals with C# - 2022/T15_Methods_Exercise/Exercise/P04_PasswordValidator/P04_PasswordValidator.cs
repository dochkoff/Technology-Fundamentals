using System;
using System.Linq;

namespace P04_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CheckPasswordLenght(password)
                && CheckOnlyLettersAndDigits(password)
                && CheckAtLeast2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CheckPasswordLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!CheckOnlyLettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!CheckAtLeast2Digits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        private static bool CheckPasswordLenght(string password)
        {
            bool passLenght = password.Length >= 6 && password.Length <= 10;
            return passLenght;

        }

        private static bool CheckOnlyLettersAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }

            }
            return true;
        }

        private static bool CheckAtLeast2Digits(string password)
        {
            int counter = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
