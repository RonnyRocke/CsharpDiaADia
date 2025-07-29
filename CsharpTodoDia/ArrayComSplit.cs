
using System;

public class FraseComSplit
{
    public void arrayscomSplit()
    {
        Console.WriteLine("Digite uma frase com 3 palavras separadas por espaço:");
        string frase = Console.ReadLine() ?? string.Empty;
        string[] vec = frase.Split(' ');
        for (int i = 0; i < vec.Length; i++)
        {
            Console.Write($"\n{vec[i]}");
        }
        
        Console.WriteLine();
        Console.WriteLine("\nObs: Agora, vamos atribuir as palavras a variáveis separadas:\n");
        for (int i = 0; i < vec.Count(); i++)
        {
            Console.WriteLine($"Digite a palavra {i + 1}:");
            // Usa o operador null-coalescing para garantir que não haja valores nulos  
            string? input = Console.ReadLine();
            vec[i] = input ?? string.Empty;
        }
        
        string p1 = vec[0];
        string p2 = vec[1];
        string p3 = vec[2];
        Console.WriteLine($"P1: {p1} P2: {p2} P3: {p3}");
    }
}