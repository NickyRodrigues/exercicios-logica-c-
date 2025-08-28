using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string bimestre;
        string f_bimestre;
        string s_bimestre;
        string t_bimestre;
        Console.WriteLine("Digite sua nota do Primeiro Bimestre: ");
        bimestre = Console.ReadLine();
        Console.WriteLine("Digite sua nota do Segundo Bimestre: ");
        f_bimestre = Console.ReadLine();
        Console.WriteLine("Digite sua nota do Terceiro Bimestre: ");
        s_bimestre = Console.ReadLine();
        Console.WriteLine("Digite sua nota do Quarto Bimestre: ");
        t_bimestre = Console.ReadLine();
        float nota_bimestre;
        float nota_f_bimestre;
        float nota_s_bimestre;
        float nota_t_bimestre;
        float.TryParse(bimestre, out nota_bimestre);
        float.TryParse(f_bimestre, out nota_f_bimestre);
        float.TryParse(s_bimestre, out nota_s_bimestre);
        float.TryParse(t_bimestre, out nota_t_bimestre);
        Console.WriteLine((nota_bimestre+nota_f_bimestre+nota_s_bimestre+nota_t_bimestre)/4);
    }
}
