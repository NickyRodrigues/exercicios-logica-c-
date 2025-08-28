/* Online C# Editor for free
errado Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
*/ 

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] vogais = {"a","e","i","o","u"};
        string letra;
        
        Console.WriteLine("Digite uma letra: ");
        letra = Console.ReadLine();
        
        if (letra.Length == 1 && char.IsLetter(letra[0]))
        {
            if(vogais.Contains(letra.ToLower()))
            {
                Console.WriteLine("Voce digitou uma vogal");
            }
            else
            {
                Console.WriteLine("Voce digitou uma consoante!");
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite apenas uma letra");
        }
    }
}