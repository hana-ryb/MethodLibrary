using MethodLibrary;

namespace MethodLibrary.Demo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, MethodLibrary!");
        
        var result = ReverseStringMethods.ReverseStringFor("Hello, MethodLibrary!");
        Console.WriteLine(result);
    }
}

