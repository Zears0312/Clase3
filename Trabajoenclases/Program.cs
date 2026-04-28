using System;
class Program
{
    static void Main()
    {
        int a = 10;
        int b= 3;
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        Console.WriteLine(a%b);
        double resultado = (double) a/b; //3.333.. 
        // conversion de string a numero
        string entrada = "42";
        int numero = int.Parse(entrada);
        //Try parse conversion segura 
        if(double.TryParse("3.14", out double pi))
            Console.WriteLine($"Pi = {pi}");
        
        // Asignacion compuesta
        int puntos = 100;
        puntos += 50;
        puntos *= 2;
    }
}