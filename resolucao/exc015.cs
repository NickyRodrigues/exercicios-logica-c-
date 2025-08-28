/* Online C# Editor for free
Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.

Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê: salário bruto. quanto pagou ao INSS. quanto pagou ao sindicato. o salário líquido. calcule os descontos e o salário líquido, conforme a tabela abaixo:

+ Salário Bruto : R$
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato ( 5%) : R$
= Salário Liquido : R$
*/ 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string htrabalhadas, hreais;
        float h_trabalhadas, h_reais, bruto, liquido;
        
        Console.WriteLine("Seu salario por hora: ");
        hreais = Console.ReadLine();
        float.TryParse(hreais, out h_reais);
        
        Console.WriteLine("Horas trabalhadas por mes: ");
        htrabalhadas = Console.ReadLine();
        float.TryParse(htrabalhadas, out h_trabalhadas);
        
        bruto = h_reais*h_trabalhadas;
        liquido = 11/100*bruto;
        Console.WriteLine(liquido);
    }
}