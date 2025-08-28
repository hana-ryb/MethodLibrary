namespace MethodLibrary;

public class Palindrome
{
    public static bool IsPalindrome(string input)
    {
        string inputToLower = input.ToLower();
        return ReverseStringMethods.ReverseStringBuilder(inputToLower) == input;
    }
    
    public static bool IsPalindromeEfficient(string input)
    {
        string inputToLower = input.ToLower();
        int left = 0;
        int right = inputToLower.Length - 1;

        while (left < right)
        {
            if (inputToLower[left] != inputToLower[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}