using System;

namespace Palindrome
{
    public class Program
    {
        static bool IsPalindrome(string s){
            return StringLib.IsPalindrome(s, true, true);
        }

        static void Check(string s, bool shouldBePalindrome){
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");  
        }
        
        public static void Main()
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);
        }
    }
}
