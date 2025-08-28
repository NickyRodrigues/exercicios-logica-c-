// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string numero, nnumero, nnnumero;
        int um, dois, tres;
        
        Console.WriteLine("Digite um numero: ");
        numero = Console.ReadLine();
        int.TryParse(numero, out um);
        
        Console.WriteLine("Digite outro numero: ");
        nnumero = Console.ReadLine();
        int.TryParse(nnumero, out dois);
        
        Console.WriteLine("Digite outro numero: ");
        nnnumero = Console.ReadLine();
        int.TryParse(nnnumero, out tres);
        
        if (numero.Length > nnumero.Length && numero.Length > nnnumero.Length)
        {
            Console.WriteLine("Numero 1 e maior");
        }
        else if (nnumero.Length > numero.Length && nnumero.Length > nnnumero.Length)
        {
            Console.WriteLine("Numero 2 e maior");
        }
        else if (nnnumero.Length > numero.Length && nnnumero.Length > nnumero.Length)
        {
            Console.WriteLine("Numero 3 e maior");
        }
    }
}