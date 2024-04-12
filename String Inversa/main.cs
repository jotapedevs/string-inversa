using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string Original = Console.ReadLine();
        string Invertida = "";

        for (int i = Original.Length - 1; i >= 0; i--)
        {
            Invertida += Original[i];
        }

        Console.WriteLine("String original: " + Original);
        Console.WriteLine("String invertida: " + Invertida);
    }
}
