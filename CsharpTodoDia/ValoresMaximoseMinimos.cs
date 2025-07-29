class ValoresMaximosEMinimos
{
    public void valoresMaximoseMinimos()
    {
        int inteiro = int.MaxValue;
        double pontoFlutuante = double.MaxValue;
        char caractere = (char)char.MaxValue;
        bool booleano = true; // O valor máximo para booleano é sempre true
        sbyte sb = sbyte.MaxValue;
        byte b = byte.MaxValue;
        short s = short.MaxValue; 
        ushort us = ushort.MaxValue;
        long l = long.MaxValue;
        ulong ul = ulong.MaxValue;
        float f = float.MaxValue;
        decimal d = decimal.MaxValue;
        // Imprime os valores máximos e mínimos dos tipos primitivos
        Console.WriteLine("\tValores Máximos e Mínimos dos Tipos Primitivos:");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Inteiro Máximo: {inteiro}");
        Console.WriteLine($"Ponto Flutuante Máximo: {pontoFlutuante}");
        Console.WriteLine($"Caractere Máximo: {caractere}");
        Console.WriteLine($"Booleano: {booleano}");
        Console.WriteLine($"SByte Máximo: {sb}");
        Console.WriteLine($"Byte Máximo: {b}");
        Console.WriteLine($"Short Máximo: {s}");
        Console.WriteLine($"UShort Máximo: {us}");
        Console.WriteLine($"Long Máximo: {l}");
        Console.WriteLine($"ULong Máximo: {ul}");
        Console.WriteLine($"Float Máximo: {f}");
        Console.WriteLine($"Decimal Máximo: {d}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();
        // Exemplo de valores mínimos
        Console.WriteLine($"Inteiro Mínimo: {int.MinValue}");
        Console.WriteLine($"Ponto Flutuante Mínimo: {double.MinValue}");
        Console.WriteLine($"Caractere Mínimo: {(char)char.MinValue}");
        Console.WriteLine($"Booleano: {false}"); // O valor mínimo para booleano é sempre false
        Console.WriteLine($"SByte Mínimo: {sbyte.MinValue}");
        Console.WriteLine($"Byte Mínimo: {byte.MinValue}");
        Console.WriteLine($"Short Mínimo: {short.MinValue}");
        Console.WriteLine($"UShort Mínimo: {ushort.MinValue}");
        Console.WriteLine($"Long Mínimo: {long.MinValue}");
        Console.WriteLine($"ULong Mínimo: {ulong.MinValue}");
        Console.WriteLine($"Float Mínimo: {float.MinValue}");
        Console.WriteLine($"Decimal Mínimo: {decimal.MinValue}");
        Console.WriteLine("----------------------------");
        Console.WriteLine();
    }
}