namespace Assignment_5_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Test examples
            int test1 = 121;
            int test2 = -121;
            int test3 = 10;

            // Call the IsPalindrome method and print results
            Console.WriteLine($"Is {test1} a palindrome? {solution.IsPalindrome(test1)}"); // Expected: true
            Console.WriteLine($"Is {test2} a palindrome? {solution.IsPalindrome(test2)}"); // Expected: false
            Console.WriteLine($"Is {test3} a palindrome? {solution.IsPalindrome(test3)}"); // Expected: false
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending with 0 (except 0 itself) cannot be palindromes
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversedHalf = 0;
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }

            // Check if the original half and the reversed half are equal
            // or if they are equal after removing the middle digit (for odd lengths)
            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
}


