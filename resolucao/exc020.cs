/* 
Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
*/ 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input;
        float memoria;
        Console.WriteLine ("Insira um numero: ");
        input = Console.ReadLine();
        float.TryParse(input, out memoria);
        if(memoria+memoria>0){
            Console.WriteLine("o numero e positivo");
        }
        else{
            Console.WriteLine("o numero e falso");
        }
    }
}