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
        double resultado = (double) a/b; //3.333.. conversion de string a numero
        string entrada = "42";
        int numero = int.parse(entrada);
    }
}