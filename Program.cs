using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string test = "Hello,   Hello,  Hello,   ";
        Console.WriteLine(test);
        Console.WriteLine(TrimSpaces(test));
        Console.ReadKey();
    }

    static string TrimSpaces(string s)
    {
        string tmp = Regex.Replace(s, "\\s{2,}", " ");
        return tmp.Trim();
    }
}