using System.Text.RegularExpressions;

namespace SecurityGame.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsOnlyLettersOrNumbers(this string source)
        {
            return Regex.IsMatch(source, @"^[a-zA-Z0-9]+$");
        }
    }
}
