using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        string celsius;
        float celsius2,calc;
        Console.WriteLine("Qual temperatura em celsius? ");
        celsius = Console.ReadLine();
        float.TryParse(celsius, out celsius2);
        Console.WriteLine((celsius2 * 9/5)+32);
        // 	(0 °C × 9/5) + 32
    }
}