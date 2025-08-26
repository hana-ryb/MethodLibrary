using System.Text;

namespace MethodLibrary;
    public static class ReverseStringMethods
{ 
    //reverse string with for loop with two iterators
    public static string ReverseStringForContra(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            result[i] = input[j];
        }
        return new string(result);
    }

    //Reverse a string by using the while loop
    public static string ReverseStringWhile(string input)
    {
        char[] result = new char[input.Length];
        int i = 0;
        int j = input.Length - 1;

        while (i < input.Length)
        {
            result[i] = input[j];
            i++;
            j--;
        }
        return new string(result);
    }

    //Reverse string by using for loop 
    public static string ReverseStringFor(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            result[i] = input[input.Length - 1 - i];
        }
        return new string(result);
    }

    //Reverse with the String builder
    public static string ReverseStringBuilder(string input)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            builder.Append(input[i]);
        }
        return builder.ToString();
    }
}