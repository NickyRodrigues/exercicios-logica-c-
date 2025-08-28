using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string salario,horas;
        Console.WriteLine("Qual seu salario por horas trabalhadas? ");
        salario = Console.ReadLine();
        float f_salario;
        float.TryParse(salario, out f_salario);
        Console.WriteLine("Quantas horas voce trabalha no mes? ");
        horas = Console.ReadLine();
        float f_horas;
        float.TryParse(horas, out f_horas);
        Console.WriteLine((f_horas*f_salario));
    }
}