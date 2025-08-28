//Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
//  Para homens: (72.7h) - 58 Para mulheres: (62.1h) - 44.7



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string dados;
        double altura;
        Console.WriteLine("Qual sua altura? ");
        dados =  Console.ReadLine();
        double.TryParse(dados, out altura);
        double homem = (72.7*altura)-58;
        double mulher = (62.1*altura)-44.7;
        Console.WriteLine("Seu peso ideial baseado na sua altura seria "+ "Para homem: "+homem+"kg" + " Para mulher: " + mulher+"kg");
    }
}