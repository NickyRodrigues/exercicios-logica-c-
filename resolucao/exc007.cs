using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string calc1, calc2;
        float area1;
        float area2;
        Console.WriteLine("Informe as medidas: ");
        calc1 = Console.ReadLine();
        Console.WriteLine("Informe as medidas: ");
        calc2 = Console.ReadLine();
        float.TryParse(calc1, out area1);
        float.TryParse(calc2, out area2);
        Console.WriteLine("A area do qudrado multiplicado por 2 = "+(area1*area2)*2);
    }
}