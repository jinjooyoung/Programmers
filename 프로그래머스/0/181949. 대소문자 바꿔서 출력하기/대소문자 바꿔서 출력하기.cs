using System;

public class Example
{
    public static void Main()
    {
        String s;
        String a = "";

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                a += char.ToLower(c);
                //Console.WriteLine(char.ToLower(c));
            }
            else
            {
                a += char.ToUpper(c);
                //Console.WriteLine(char.ToUpper(c));
            }
            
        }
        Console.WriteLine(a);

    }
}