/* 
Faça um Programa que peça dois números e imprima o maior deles.
*/ 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input1, input2;
        float memoria1, memoria2;
        Console.WriteLine ("Insira um numero: ");
        input1 = Console.ReadLine();
        float.TryParse(input1, out memoria1);
        
        Console.WriteLine ("Insira outr numero: ");
        input2 = Console.ReadLine();
        float.TryParse(input2, out memoria2);
        if(memoria1>memoria2){
            Console.WriteLine("O primeiro numero e maior");
        }
        else{
            Console.WriteLine("O segundo numero e maior: ");
        }
    }
}