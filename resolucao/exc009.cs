using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string farenheit;
        float calc, resultado;
        Console.WriteLine("Qual temperatura em Farenheit? ");
        farenheit = Console.ReadLine();
        float.TryParse(farenheit, out calc);
        resultado = (5*(calc-32)/9);
        Console.WriteLine(resultado);
    }
}