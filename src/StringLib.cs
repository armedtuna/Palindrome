namespace Palindrome
{
    public static class StringLib
    {
        public static string RemoveSpaces(string s)
        {
            if (s == null)
            {
                return null;
            }

            return s
                .Replace(" ", "");
        }

        public static bool IsPalindrome(string s, bool removeSpaces, bool lowerCase){
            if (string.IsNullOrEmpty(s))
            {
                // is a null or empty string a palindrome?
                return false;
            }

            var cs = removeSpaces
                ? StringLib.RemoveSpaces(s)
                : s;

            cs = lowerCase
                ? cs.ToLower()
                : cs;

            var leftIndex = 0;
            var rightIndex = cs.Length - 1;
            var proceed = true;
            while (proceed && leftIndex < rightIndex)
            {
                var left = cs[leftIndex];
                var right = cs[rightIndex];

                proceed = char.Equals(left, right);
                leftIndex++;
                rightIndex--;
            }

            return proceed;
        }
    }
}