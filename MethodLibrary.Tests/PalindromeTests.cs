using NUnit.Framework;
namespace MethodLibrary.Tests;

[TestFixture]
public class PalindromeTests
{
    [Test]
    public void TestIsPalindrome()
    {
        string[] testCases = {"racecar", "hello", "A man a plan a canal Panama", "Racecar", "12321"};

        foreach (string test in testCases)
        {
            Console.WriteLine($"{test} is palindrome: {Palindrome.IsPalindrome(test)}");
        }
    }
}   