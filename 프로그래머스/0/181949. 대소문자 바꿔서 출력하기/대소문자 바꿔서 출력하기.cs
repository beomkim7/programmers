using System;

public class Example
{
    public static void Main()
    {
            String s;

            Console.Clear();
            s = Console.ReadLine();
            char[] check = s.ToCharArray();

            for(int i = 0; i < check.Length; i++)
            {
                if (char.IsUpper(check[i])) check[i] =char.ToLower(check[i]);
                else if (char.IsLower(check[i])) check[i] = char.ToUpper(check[i]);
            }
            s = new string(check);
            Console.WriteLine(s);

    }
}