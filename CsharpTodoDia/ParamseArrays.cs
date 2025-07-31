class ParamseArrays
{
    // Método que recebe um número variável de parâmetros
    // e calcula a soma de todos eles
    public void somandoTudo(params int[] numeros)
    {
        if (numeros.Length == 0)
        {
            throw new ArgumentException("Nenhum número foi fornecido para somar.");

        }
        else
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}