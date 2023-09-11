using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ShiftString;
public static class Program
{
    public static void Main(string[] args)
    {
        //args example: 
        //a,b,c c,d,e
        //a,a,a a,a
        string[] a = args[0].Split(",");
        string[] b = args[1].Split(",");

        var result = can_shift(a, b);
        Console.WriteLine($" Result of can_shift is: {result}");
    }

    private static bool can_shift(string[] a, string[] b)
    {
        if (a.Length != b.Length)
            return false;

        Dictionary<string, int> data = new();
        foreach(var element in a)
        {
            if (!data.ContainsKey(element))
                data.Add(element, 1);
            else
                data[element] ++;
        }

        foreach (var elementB in b)
        {
            if (!data.ContainsKey(elementB))
                return false;

            data[elementB] --;
            if (data[elementB] < 0 )
                return false;
        }

        return true;
    }
}