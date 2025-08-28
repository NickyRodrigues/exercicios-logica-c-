using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string metros;
        Console.WriteLine("Insira o valor em metros: ");
        metros = Console.ReadLine();
        float centimetros;
        float.TryParse(metros, out centimetros);
        Console.WriteLine(metros + "m sao " + centimetros*100 + "cm");
        Console.ReadLine();
    }
}