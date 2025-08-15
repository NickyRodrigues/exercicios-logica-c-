using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string numero1;
        string numero2;
        Console.WriteLine ("Me de um numero");
        numero1 = Console.ReadLine();
        Console.WriteLine("Me de outro numero");
        numero2 = Console.ReadLine();
        int numero10 = int.Parse(numero1);
        int numero20 = int.Parse(numero2);
        Console.WriteLine(numero10 + numero20);
    }
}
