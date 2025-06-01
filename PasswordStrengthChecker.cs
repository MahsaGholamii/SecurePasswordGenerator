using System.Text.RegularExpressions;

namespace SecurePasswordGenerator
{
    public static class PasswordStrengthChecker
    {
        public static string Evaluate(string password)
        {
            int score = 0;

            if (password.Length >= 8) score++;
            if (Regex.IsMatch(password, "[a-z]")) score++;
            if (Regex.IsMatch(password, "[A-Z]")) score++;
            if (Regex.IsMatch(password, "[0-9]")) score++;
            if (Regex.IsMatch(password, "[!@#$%^&*()]")) score++;

            return score switch
            {
                <= 2 => "Weak",
                3 => "Moderate",
                4 => "Strong",
                5 => "Very Strong",
                _ => "Unknown"
            };
        }
    }
}