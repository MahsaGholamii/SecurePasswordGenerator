using System;

namespace SecurePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔐 Secure Password Generator\n");

            Console.Write("Enter desired password length (8-32): ");
            int length = int.Parse(Console.ReadLine());

            string password = PasswordGenerator.Generate(length);
            Console.WriteLine($"\nGenerated Password: {password}");

            string strength = PasswordStrengthChecker.Evaluate(password);
            Console.WriteLine($"Password Strength: {strength}");
        }
    }
}