using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ShiftString;
public static class Program
{
    public static void Main(string[] args)
    {
        //args example: 
        //abcd bcda
        string a = args[0];
        string b = args[1];

        var result = can_shift(a, b);
        Console.WriteLine($" Result of can_shift is: {result}");
    }

    private static bool can_shift(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        int posBinA = a.IndexOf(b[0]);
        if (posBinA == -1)
            return false;
        Console.WriteLine(posBinA);

        var newString = a.Substring(posBinA)+a.Substring(0, posBinA);
        Console.WriteLine($"NEw String: {newString}");
        if (!newString.Equals(b))
            return false;

        return true;
    }
}