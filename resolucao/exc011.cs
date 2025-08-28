//Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre: o produto do dobro do primeiro com metade do segundo. a soma do triplo do primeiro com o terceiro. o terceiro elevado ao cubo.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string inteiro, real;
        float valor, valor2, valores;
        Console.WriteLine("Insira um valor inteiro: ");
        inteiro = Console.ReadLine();
        float.TryParse(inteiro, out valor);
        Console.WriteLine("Insite um valor real: ");
        real = Console.ReadLine();
        float.TryParse(real, out valor2);
        valores = ((valor*2)+(valor2/2));
        Console.WriteLine(valores);
        Console.WriteLine((valor*3)+valores);
        Console.WriteLine(Math.Pow(valores, 3));
    }
}