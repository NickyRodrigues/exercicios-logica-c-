// Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string raio;
        Console.WriteLine ("Insira o raio do cirulo: ");
        raio = Console.ReadLine();
        float calculo;
        float pi = 3.14f;
        float.TryParse(raio, out calculo);
        Console.WriteLine("A area do circulo e: " +(calculo*calculo)*pi);
        Console.ReadLine();
    }
}